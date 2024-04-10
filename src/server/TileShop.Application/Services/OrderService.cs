using AutoMapper;
using TileShop.Application.Services.Interfaces;
using TileShop.Domain.Dtos;
using TileShop.Domain.Entities;
using TileShop.Domain.Repositories;

namespace TileShop.Application.Services;

public class OrderService : IOrderService
{
    private readonly IBasketService _basketService;
    private readonly IOrderRepository _orderRepository;
    private readonly IMapper _mapper;

    public OrderService(IBasketService basketService, IOrderRepository orderRepository, IMapper mapper)
    {
        _basketService = basketService;
        _orderRepository = orderRepository;
        _mapper = mapper;
    }

    public async Task<List<OrderDto>> GetUserOrdersAsync(int userId)
    {
        var orders = await _orderRepository.GetUserOrdersAsync(userId);
        return _mapper.Map<List<OrderDto>>(orders);
    }

    public async Task<OrderDto> DoCheckoutAsync(int userId)
    {
        var basket = await _basketService.GetUserBasketAsync(userId);
        var basketDetails = await _basketService.GetBasketItemsAsync(basket.Id);
        if (!basketDetails.Any())
        {
            throw new Exception("Basket is empty");
        }
        var orderDetails = _mapper.Map<List<OrderDetails>>(basketDetails);
        var order = new Order
        {
            CreatedDate = DateTime.UtcNow,
            UserId = userId,
            Details = orderDetails
        };
        var createdOrder = await _orderRepository.CreateAsync(order);
        return _mapper.Map<OrderDto>(createdOrder);
    }
}

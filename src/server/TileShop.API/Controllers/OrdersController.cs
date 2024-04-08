using Microsoft.AspNetCore.Mvc;

namespace TileShop.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OrdersController : ControllerBase
{
    public OrdersController()
    {
        
    }

    [HttpGet]
    public void GetOrders()
    {

    }

    [HttpGet("{id}")]
    public void GetOrder()
    {

    }

    [HttpPost]
    public void CreateOrder()
    {

    }
}

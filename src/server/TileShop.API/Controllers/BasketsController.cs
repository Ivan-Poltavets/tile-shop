using Microsoft.AspNetCore.Mvc;

namespace TileShop.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BasketsController : ControllerBase
{
    public BasketsController()
    {
        
    }

    [HttpGet]
    public void GetBasket()
    {

    }

    [HttpPost("items")]
    public void AddItemToBasket()
    {

    }

    [HttpPut("items/{id}")]
    public void UpdateBasketItem(int id)
    {

    }

    [HttpDelete("items/{id}")]
    public void DeleteBasketItem(int id)
    {

    }
}

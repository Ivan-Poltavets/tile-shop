using Microsoft.AspNetCore.Mvc;

namespace TileShop.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    public ProductsController()
    {
        
    }

    [HttpGet]
    public void GetProducts()
    {

    }

    [HttpGet("{id}")]
    public void GetProduct(int id)
    {

    }

    [HttpPost]
    public void CreateProduct()
    {

    }

    [HttpPut("{id}")]
    public void UpdateProduct(int id)
    {

    }

    [HttpDelete("{id}")]
    public void DeleteProduct(int id)
    {

    }
}

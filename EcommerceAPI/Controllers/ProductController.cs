using Microsoft.AspNetCore.Mvc;
using EcommerceAPI.Services;
using EcommerceAPI.Models;

namespace EcommerceAPI.Controllers;

[ApiController]
[Route("/api/product/")]
public class ProductController : Controller
{
    private readonly IEcommerceService<Product> _service;
    public ProductController(IEcommerceService<Product> service)
    {
        _service = service;
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody]Product product)
    {
        await _service.Create(product);
        return Ok(product);
    }

    [HttpGet]
    public async Task<IActionResult> ReadAll()
    {
        return Ok(await _service.ReadAll());
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> ReadById(int id)
    {
        return Ok(await _service.ReadById(id));
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody]Product product)
    {
        await _service.Update(product);
        return Ok(product);
    }
}
using Microsoft.AspNetCore.Mvc;
using EcommerceAPI.Services;
using EcommerceAPI.Models;

namespace EcommerceAPI.Controllers;

[ApiController]
[Route("/api/productsale/")]
public class ProductSaleController : Controller
{
    private readonly IEcommerceService<ProductSale> _service;
    public ProductSaleController(IEcommerceService<ProductSale> service)
    {
        _service = service;
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
}
using Microsoft.AspNetCore.Mvc;
using EcommerceAPI.Services;
using EcommerceAPI.Models;

namespace EcommerceAPI.Controllers;

[ApiController]
[Route("/api/sale/")]
public class SaleController : Controller
{
    private readonly IEcommerceService<Sale> _service;
    public SaleController(IEcommerceService<Sale> service)
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
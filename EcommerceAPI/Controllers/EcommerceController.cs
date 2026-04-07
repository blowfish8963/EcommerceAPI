using EcommerceAPI.Models;
using EcommerceAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EcommerceController<T> : ControllerBase where T : class
{
    private readonly IEcommerceService<T> _ecommerceService;
    public EcommerceController(IEcommerceService<T> EcommerceService)
    {
        _ecommerceService = EcommerceService;
    }
    
    [HttpGet]
    public async Task<IActionResult> ReadAll()
    {
        return Ok(await _ecommerceService.ReadAll());
    }
}
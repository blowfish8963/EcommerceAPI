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
    
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] T entity)
    {
        await _ecommerceService.Create(entity);
        return Ok(entity);
    }

    [HttpGet]
    public async Task<IActionResult> ReadAll()
    {
        return Ok(await _ecommerceService.ReadAll());
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> ReadById(int id)
    {
        return Ok(await _ecommerceService.ReadById(id));
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] T entity)
    {
        return Ok(_ecommerceService.Update(entity));
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        return Ok(_ecommerceService.Delete(id));
    }
}

public class CategoryController : EcommerceController<Category>
{
    public CategoryController(IEcommerceService<Category> service) : base(service) {}
}
using Microsoft.AspNetCore.Mvc;
using EcommerceAPI.Services;
using EcommerceAPI.Models;

namespace EcommerceAPI.Controllers;

[ApiController]
[Route("/api/category/")]
public class CategoryController : Controller
{
    private readonly IEcommerceService<Category> _service;
    public CategoryController(IEcommerceService<Category> service)
    {
        _service = service;
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody]Category category)
    {
        await _service.Create(category);
        return Ok(category);
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
    public async Task<IActionResult> Update([FromBody]Category category)
    {
        await _service.Update(category);
        return Ok(category);
    }
}
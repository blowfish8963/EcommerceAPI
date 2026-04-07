using EcommerceAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controllers;

[ApiController]
[Route("api/ecommerce")]
public class EcommerceController<T> : ControllerBase where T : class
{
    private readonly IEcommerceService<T> _ecommerceService;
    public EcommerceController(IEcommerceService<T> EcommerceService)
    {
        _ecommerceService = EcommerceService;
    }
    
    
}
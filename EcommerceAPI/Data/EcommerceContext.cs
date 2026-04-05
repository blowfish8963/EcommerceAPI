using Microsoft.EntityFrameworkCore;
using EcommerceAPI.Models;

namespace EcommerceAPI.Data;

public class EcommerceContext : DbContext
{
    public EcommerceContext(DbContextOptions options) : base(options)
    {
        
    }

    // dbsets
}
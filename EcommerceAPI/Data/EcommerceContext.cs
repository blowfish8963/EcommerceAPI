using Microsoft.EntityFrameworkCore;
using EcommerceAPI.Models;

namespace EcommerceAPI.Data;

public class EcommerceContext : DbContext
{
    public EcommerceContext(DbContextOptions options) : base(options)
    {
        
    }

    public DbSet<Category> Categories {get;set;}
    public DbSet<Product> Products {get;set;}
    public DbSet<Sale> Sales {get;set;}
}
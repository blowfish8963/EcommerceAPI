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
    public DbSet<ProductSale> ProductSales {get;set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>()
        .HasMany(x => x.Sales)
        .WithMany(x => x.Products)
        .UsingEntity<ProductSale>();
    }
}
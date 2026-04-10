using Microsoft.EntityFrameworkCore;
using EcommerceAPI.Models;

namespace EcommerceAPI.Data;

public class EcommerceContext : DbContext
{
    public EcommerceContext(DbContextOptions options) : base(options) {}
    
    public DbSet<Category> Categories {get;set;}
    public DbSet<Product> Products {get;set;}
    public DbSet<Sale> Sales {get;set;}
    public DbSet<ProductSale> ProductSales {get;set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ProductSale>()
        .HasKey(x => new {x.ProductId, x.SaleId});

        modelBuilder.Entity<ProductSale>()
        .HasOne(x => x.Product)
        .WithMany(x => x.ProductSales)
        .HasForeignKey(x => x.ProductId);

        modelBuilder.Entity<ProductSale>()
        .HasOne(x => x.Sale)
        .WithMany(x => x.ProductSales)
        .HasForeignKey(x => x.SaleId);
    }
}
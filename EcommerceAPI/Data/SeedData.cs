using EcommerceAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EcommerceAPI.Data;

public class Seeder()
{
    public static async Task SeedDb(EcommerceContext dbContext)
    {
        if (!await dbContext.Categories.AnyAsync())
        {
            
            var c1 = new Category{CategoryName="Monitors"};
            var c2 = new Category{CategoryName="Headsets"};
            var c3 = new Category{CategoryName="Keyboards"};
            await dbContext.Categories.AddRangeAsync(c1, c2, c3);
            await dbContext.SaveChangesAsync();
       
            var p1 = new Product {ProductName="Random monitor", ProductPrice=2999.99m, CategoryId=c1.CategoryId};
            var p2 = new Product {ProductName="Razor kraken", ProductPrice=1999.99m, CategoryId=c2.CategoryId};
            var p3 = new Product {ProductName="Random headset", ProductPrice=1000, CategoryId=c2.CategoryId};
            var p4 = new Product {ProductName="Random keyboard", ProductPrice=999.99m, CategoryId=c3.CategoryId};
            await dbContext.Products.AddRangeAsync(p1, p2, p3, p4);
            await dbContext.SaveChangesAsync();

            var s1 = new Sale {SaleTotal=2000};
            var s2 = new Sale {SaleTotal=5999.98m};
            var s3 = new Sale {SaleTotal=2999.97m};
            await dbContext.Sales.AddRangeAsync(s1, s2, s3);
            await dbContext.SaveChangesAsync();

            await dbContext.ProductSales.AddRangeAsync(
                new ProductSale {ProductId=p3.ProductId, SaleId=s1.SaleId, ProductQty=2},
                new ProductSale {ProductId=p1.ProductId, SaleId=s2.SaleId, ProductQty=2},
                new ProductSale {ProductId=p4.ProductId, SaleId=s3.SaleId, ProductQty=3}
            );
            await dbContext.SaveChangesAsync();
        }          
    }
}
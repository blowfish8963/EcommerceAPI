using System.ComponentModel.DataAnnotations;

namespace EcommerceAPI.Models;

public class Sale
{
    public int SaleId {get;set;}
    public decimal SaleTotal {get;set;}
    [Required]
    public List<Product> Products {get;set;}
    [Required]
    public List<ProductSale> ProductSales {get;set;}
}
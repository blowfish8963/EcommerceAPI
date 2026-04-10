using System.ComponentModel.DataAnnotations;

namespace EcommerceAPI.Models;

public class Sale
{
    public int SaleId {get;set;}
    public decimal SaleTotal {get;set;}
    public List<Product>? Products {get;set;}
    public List<ProductSale>? ProductSales {get;set;}
}
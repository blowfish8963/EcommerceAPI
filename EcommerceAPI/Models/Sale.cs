namespace EcommerceAPI.Models;

public class Sale
{
    public int SaleId {get;set;}
    public decimal SaleTotal {get;set;}
    public List<Product>? Products {get;set;}
}
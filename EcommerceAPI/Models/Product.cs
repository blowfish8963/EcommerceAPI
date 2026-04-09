namespace EcommerceAPI.Models;

public class Product
{
    public int ProductId {get;set;}
    public string? ProductName {get;set;}
    public decimal ProductPrice {get;set;}
    public int ProductQty {get;set;} = 0;
    public int CategoryId {get;set;}
    public Category? Category {get;set;} 
    public List<Sale>? Sales {get;set;}
}
using System.Text;
using EcommerceAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace EcommerceAPI;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder();

        builder.Services.AddControllers();
        builder.Services.AddDbContext<EcommerceContext>(x => x.UseSqlite(builder.Configuration.GetConnectionString("ConnectionString")));
        // other services

        var app = builder.Build();
        app.Run();
    }
}
using EcommerceAPI.Data;
using EcommerceAPI.Repositories;
using EcommerceAPI.Services;
using Microsoft.EntityFrameworkCore;

namespace EcommerceAPI;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder();

        builder.Services.AddControllers();
        builder.Services.AddDbContext<EcommerceContext>(x => x.UseSqlite(builder.Configuration.GetConnectionString("ConnectionString")));
        builder.Services.AddScoped(typeof(IEcommerceRepository<>), typeof(EcommerceRepository<>));
        builder.Services.AddScoped(typeof(IEcommerceService<>), typeof(EcommerceService<>));

        var app = builder.Build();
        app.Run();
    }
}
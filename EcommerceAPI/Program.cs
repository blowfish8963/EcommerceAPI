using EcommerceAPI.Data;
using static EcommerceAPI.Data.Seeder;
using EcommerceAPI.Repositories;
using EcommerceAPI.Services;
using Microsoft.EntityFrameworkCore;

namespace EcommerceAPI;

public class Program
{
    public static async Task Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder();

        builder.Services.AddControllers();
        builder.Services.AddDbContext<EcommerceContext>(x => x.UseSqlite(builder.Configuration.GetConnectionString("ConnectionString")));
        builder.Services.AddScoped(typeof(IEcommerceRepository<>), typeof(EcommerceRepository<>));
        builder.Services.AddScoped(typeof(IEcommerceService<>), typeof(EcommerceService<>));

        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            using (var scope = app.Services.CreateAsyncScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<EcommerceContext>();
                await SeedDb(dbContext);
            }
        }
        app.MapControllers();
        app.Run();
    }
}
using EcommerceAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace EcommerceAPI.Repositories;

public interface IEcommerceRepository<T> where T : class
{
    
}

public class EcommerceRepository<T> : IEcommerceRepository<T> where T : class
{
    private readonly EcommerceContext _dbContext;
    private readonly DbSet<T> _dbSet;
    public EcommerceRepository(EcommerceContext DbContext)
    {
        _dbContext = DbContext;
        _dbSet = DbContext.Set<T>();
    }

    
}
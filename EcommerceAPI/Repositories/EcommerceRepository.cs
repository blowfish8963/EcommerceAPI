using EcommerceAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace EcommerceAPI.Repositories;

public interface IEcommerceRepository<T> where T : class
{
    //Task Create(T entity);
    //Task<T> ReadById(int id);
    Task<IEnumerable<T>> ReadAll();
    //Task Update(int id, T newEntity);
    //Task Delete(int id);
}

public class EcommerceRepository<T> : IEcommerceRepository<T> where T : class
{
    private readonly EcommerceContext _dbContext;
    public EcommerceRepository(EcommerceContext DbContext)
    {
        _dbContext = DbContext;
    }

    public async Task<IEnumerable<T>> ReadAll()
    {
        return await _dbContext.Set<T>().ToListAsync();
    }
}
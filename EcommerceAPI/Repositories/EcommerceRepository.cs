using EcommerceAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace EcommerceAPI.Repositories;

public interface IEcommerceRepository<T> where T : class
{
    Task Create(T entity);
    Task<T> ReadById(int id);
    Task<IEnumerable<T>> ReadAll();
    Task Update(T newEntity);
    Task Delete(int id);
}

public class EcommerceRepository<T> : IEcommerceRepository<T> where T : class
{
    private readonly EcommerceContext _dbContext;
    public EcommerceRepository(EcommerceContext DbContext)
    {
        _dbContext = DbContext;
    }

    public async Task Create(T entity)
    {
        await _dbContext.Set<T>().AddAsync(entity);
        await Save();
    }

    public async Task<IEnumerable<T>> ReadAll()
    {
        return await _dbContext.Set<T>().ToListAsync();
    }

    public async Task<T> ReadById(int id)
    {
        var entity = await _dbContext.Set<T>().FindAsync(id);
        if (entity == null) throw new KeyNotFoundException();
        return entity;
    }

    public async Task Update(T entity)
    {
        _dbContext.Set<T>().Update(entity);
        await Save();
    }

    public async Task Delete(int id)
    {
        var entity = await _dbContext.Set<T>().FindAsync(id);
        if (entity == null) throw new KeyNotFoundException();
        _dbContext.Set<T>().Remove(entity);
        await Save();
    }

    private async Task Save()
    {
        await _dbContext.SaveChangesAsync();
    }
}
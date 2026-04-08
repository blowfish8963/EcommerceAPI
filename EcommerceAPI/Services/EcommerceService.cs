using EcommerceAPI.Repositories;

namespace EcommerceAPI.Services;

public interface IEcommerceService<T> where T : class
{
    Task Create(T entity);
    Task<IEnumerable<T>> ReadAll();
    Task<T> ReadById(int id);
    Task Update(T entity);
    Task Delete(int id);
}
public class EcommerceService<T> : IEcommerceService<T> where T : class
{
    private readonly IEcommerceRepository<T> _eccommerceRepository;
    public EcommerceService(IEcommerceRepository<T> EcommerceRepository)
    {
        _eccommerceRepository = EcommerceRepository;
    }

    public async Task Create(T entity)
    {
        await _eccommerceRepository.Create(entity);
    }

    public async Task<IEnumerable<T>> ReadAll()
    {
        return await _eccommerceRepository.ReadAll();
    }

    public async Task<T> ReadById(int id)
    {
        return await _eccommerceRepository.ReadById(id);
    }

    public async Task Update(T entity)
    {
        await _eccommerceRepository.Update(entity);
    }

    public async Task Delete(int id)
    {
        await _eccommerceRepository.Delete(id);
    }
}
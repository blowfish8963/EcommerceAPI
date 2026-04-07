using EcommerceAPI.Repositories;

namespace EcommerceAPI.Services;

public interface IEcommerceService<T> where T : class
{
    Task<IEnumerable<T>> ReadAll();
}
public class EcommerceService<T> : IEcommerceService<T> where T : class
{
    private readonly IEcommerceRepository<T> _eccommerceRepository;
    public EcommerceService(IEcommerceRepository<T> EcommerceRepository)
    {
        _eccommerceRepository = EcommerceRepository;
    }

    public async Task<IEnumerable<T>> ReadAll()
    {
        return await _eccommerceRepository.ReadAll();
    }
}
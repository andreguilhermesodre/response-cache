using ResponseCache.Domain.Entitites;

namespace ResponseCache.Domain.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
    }
}

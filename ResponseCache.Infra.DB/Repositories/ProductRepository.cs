using Bogus;
using ResponseCache.Domain.Entitites;
using ResponseCache.Domain.Interfaces;

namespace ResponseCache.Infra.DB.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public IEnumerable<Product> GetAllProducts()
        {
            var productsList = new List<Product>();
            var faker = new Faker();
            for (int i = 0; i < 100; i++)
            {
                var product = new Product(faker.Commerce.ProductName(), faker.Commerce.Categories(faker.Random.Number(1, 5)), faker.Commerce.Ean13());
                productsList.Add(product);
            }
            Thread.Sleep(5000);
            return productsList;
        }
    }
}

using MediatR;
using ResponseCache.Domain.Entitites;
using ResponseCache.Domain.Interfaces;

namespace ResponseCache.Application.Features.Queries.GetAllProducts
{
    public class GetAllProductsQuery : IRequest<IEnumerable<Product>>
    {
    }

    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, IEnumerable<Product>>
    {
        private readonly IProductRepository _productRepository;
        public GetAllProductsQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        
        public async Task<IEnumerable<Product>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            var productsList = _productRepository.GetAllProducts();            
            return await Task.FromResult(productsList);
        }
    }
}

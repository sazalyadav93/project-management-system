using MediatR;
using ProductManagementSystem.Models;
using ProductManagementSystem.Queries;
using ProductManagementSystem.Repositories;

namespace ProductManagementSystem.Handlers
{
    public class GetProductListHandler : IRequestHandler<GetProductListQuery, List<Product>>
    {
        private readonly IProductRepository _productRepository;
        public GetProductListHandler(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }
         
        public async Task<List<Product>> Handle(GetProductListQuery query, CancellationToken cancellationToken)
        {
            return await _productRepository.GetProductListAsync();
        }
    }
}

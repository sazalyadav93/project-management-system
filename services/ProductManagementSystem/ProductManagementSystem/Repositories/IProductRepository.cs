using ProductManagementSystem.Models;

namespace ProductManagementSystem.Repositories
{
    public interface IProductRepository
    {
        public Task<List<Product>>  GetProductListAsync();
    }
}

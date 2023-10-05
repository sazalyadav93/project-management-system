using Microsoft.EntityFrameworkCore;
using ProductManagementSystem.Data;
using ProductManagementSystem.Models;

namespace ProductManagementSystem.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductDbContext _productDbContext;

        public ProductRepository(ProductDbContext productDbContext)
        {
            this._productDbContext = productDbContext;
        }

        public async Task<List<Product>> GetProductListAsync()
        {
            var products = await _productDbContext.Products.ToListAsync();
            return products;
        }
    }
}

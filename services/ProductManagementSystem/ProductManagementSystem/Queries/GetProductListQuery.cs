using MediatR;
using ProductManagementSystem.Models;

namespace ProductManagementSystem.Queries
{
    public class GetProductListQuery : IRequest<List<Product>>
    {
    }
}

using MediatR;
using Microsoft.AspNetCore.Mvc;
using ProductManagementSystem.Models;
using ProductManagementSystem.Queries;

namespace ProductManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ProductsController(IMediator mediator)
        {
            this._mediator = mediator;

        }

        [HttpGet]
        public async Task<List<Product>> GetProductListAsync()
        {
            var products = await _mediator.Send(new GetProductListQuery());
            return products;

        }
    }

}
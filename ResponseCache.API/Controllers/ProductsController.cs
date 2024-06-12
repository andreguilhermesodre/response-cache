using MediatR;
using Microsoft.AspNetCore.Mvc;
using ResponseCache.Application.Features.Queries.GetAllProducts;

namespace ResponseCache.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator mediator;

        public ProductsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get(string test)
        {
            var request = new GetAllProductsQuery();
            var result = await mediator.Send(request);
            return Ok(result);
        }
    }
}
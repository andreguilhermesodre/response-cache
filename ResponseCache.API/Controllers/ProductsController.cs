using MediatR;
using Microsoft.AspNetCore.Mvc;
using ResponseCache.Application.Features.Queries.GetAllProducts;

namespace ResponseCache.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var request = new GetAllProductsQuery();
            var result = await _mediator.Send(request);
            return Ok(result);
        }
    }
}
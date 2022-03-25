using MediatR;
using Microsoft.Extensions.Caching.Distributed;

namespace ResponseCache.Application.Common.Behaviors
{
    public class ResponseCacheBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : IRequest<TResponse>
    {
        private readonly IDistributedCache _cache;
        public ResponseCacheBehavior(IDistributedCache cache)
        {
            _cache = cache;
        }

        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {
            return await next();
        }
    }
}

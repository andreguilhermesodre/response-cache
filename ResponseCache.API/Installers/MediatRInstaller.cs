using MediatR;
using ResponseCache.Application.Common.Behaviors;
using ResponseCache.Application.Features.Queries.GetAllProducts;
using System.Reflection;

namespace ResponseCache.API.Installers
{
    public static class MediatRInstaller
    {
        public static void InstallMediatR(this IServiceCollection services)
        {
            services.AddMediatR(typeof(GetAllProductsQuery));
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ResponseCacheBehavior<,>));
        }
    }
}

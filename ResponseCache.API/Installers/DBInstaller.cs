using ResponseCache.Domain.Interfaces;
using ResponseCache.Infra.DB.Repositories;

namespace ResponseCache.API.Installers
{
    public static class DBInstaller
    {
        public static void InstallDB(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();
        }
    }
}

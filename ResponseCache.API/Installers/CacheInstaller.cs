namespace ResponseCache.API.Installers
{
    public static class CacheInstaller
    {
        public static void InstallCache(this IServiceCollection services)
        {
            var redisConnectionString = "localhost";
            services.AddStackExchangeRedisCache(o => o.Configuration = redisConnectionString);
        }
    }
}

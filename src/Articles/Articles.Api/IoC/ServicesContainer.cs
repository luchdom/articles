using Articles.Api.Services;
using Articles.Api.Services.Interfaces;

namespace Articles.Api.IoC;

public static class ServicesContainer
{
    public static IServiceCollection AddServicesCustomers(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IArticlesServices, ArticlesService>();

        return services;
    }
}

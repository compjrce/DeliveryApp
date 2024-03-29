using DeliveryApp.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DeliveryApp.Application;

public static class ApplicationModule
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddApplicationServices();

        return services;
    }

    private static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<IMotoService, MotoService>();
        services.AddScoped<IDeliveryDriverService, DeliveryDriverService>();
        services.AddScoped<IOrderService, OrderService>();

        return services;
    }
}
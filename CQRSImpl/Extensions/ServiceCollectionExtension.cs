using CQRSImpl.Command;
using CQRSImpl.Handler;

namespace CQRSImpl.Extensions;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddTransientCollection(this IServiceCollection services)
    {
        services.AddTransient<ICommandHandler<RateProductCommand>, RateProductCommandHandler>();
        services.AddTransient<ICommandHandler<CreateProductCommand>, CreateProductCommandHandler>(); 
        return services;
    }
    public static IServiceCollection AddSingletonCollection(this IServiceCollection services)
    {
        services.AddSingleton<CommandDispatcher>();
        return services;
    }
}

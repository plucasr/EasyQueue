using Microsoft.Extensions.DependencyInjection;

namespace EasyQueue;

public static class EasyQueueConfig
{
    public static IServiceCollection AddEasyQueue(this IServiceCollection services)
    {
        services.AddSingleton<IQueueListener, QueueListener>();
        services.AddSingleton<IQueueService, QueueService>();
        return services;
    }
}

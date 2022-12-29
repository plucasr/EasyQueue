using Microsoft.Extensions.DependencyInjection;

namespace HailaQueue;

public static class HailaQueueConfig
{
    public static IServiceCollection AddHailaQueue(this IServiceCollection services)
    {
        services.AddSingleton<IQueueListener, QueueListener>();
        services.AddSingleton<IQueueService, QueueService>();
        return services;
    }
}

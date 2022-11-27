using LiveTiming.Domain;
using Microsoft.Extensions.DependencyInjection;

namespace LiveTiming.Infrastructure;

public static class Extensions
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        services.AddScoped<ITimedLapRepository, MemoryTImedLapRepository>();
        return services;
    }
}
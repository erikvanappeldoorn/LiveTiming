using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace LiveTiming.Application;

public static class Extensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddMediatR(Assembly.GetExecutingAssembly());
        return services;
    }
}
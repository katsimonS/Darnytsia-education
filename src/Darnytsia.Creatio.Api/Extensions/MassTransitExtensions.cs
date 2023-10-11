using MassTransit;
using Microsoft.Extensions.DependencyInjection;

namespace Darnytsia.Creatio.Api.Extensions;

public static class MassTransitExtensions
{
    public static void AddDarnytsiaBus(this IServiceCollection services)
    {
        services.AddCreatioMassTransit(x =>
        {
            x.AddConsumers(typeof(IApiAssemblyMarker).Assembly);
            x.UsingCreatioInMemory((context, cfg) =>
            {
                cfg.ConfigureEndpoints(context);
            });
        });
    }
}

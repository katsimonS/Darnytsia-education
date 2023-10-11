using Darnytsia.Creatio.Abstractions;
using Darnytsia.Creatio.Api;
using Darnytsia.Creatio.Api.Extensions;
using Darnytsia.Creatio.Core;
using Darnytsia.Creatio.Data;
using Darnytsia.Creatio.Data.Entities.GraphQL;
using Darnytsia.Creatio.Data.Entities.Mapping;
using Darnytsia.Creatio.Infrastructure.Persistence;
using Edenlab.Creatio.DependencyInjection.Extensions;
using Edenlab.Creatio.EF.Extensions;
using Edenlab.Creatio.Identities.Extensions;
using Edenlab.Creatio.Logging.Extensions;
using Edenlab.Creatio.Process.Extensions;
using Edenlab.Creatio.Web.Abstractions;
using Edenlab.Creatio.Web.AspNet.Extensions;
using Edenlab.Creatio.Web.AspNet.GraphQL.Extensions;
using Edenlab.Creatio.Web.AspNet.Swashbuckle;
using Edenlab.Creatio.Web.Entities;
using Edenlab.Creatio.Web.Extensions;
using Edenlab.Creatio.Web.Hosting;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Globalization;
using System.Web.Hosting;
using Terrasoft.Core;

namespace Darnytsia.Creatio;

public class Startup : StartupBase
{
    public Startup(AppConnection appConnection)
        : base(appConnection)
    {
    }

    public override void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
        base.ConfigureServices(services, configuration);
        services.AddUserContext();
        services.AddCreatioLogging(configuration, HostingEnvironment.ApplicationVirtualPath);
        services.AddControllers(typeof(IApiAssemblyMarker));
        services.AddMssqlDbProvider(configuration.GetConnectionString("Db"));
        services.AddDbContext<IDbContext, DarnytsiaDbContext>(options =>
        {
            options.UseAdminRights = false;
            options.EntityClassMarkers.Add(typeof(IDataAssemblyMarker));
        });
        services.AddEntityInterceptors(typeof(ICoreAssemblyMarker));
        services.AddEntityCodeGen();

        services.AddAutoMapper(
            typeof(ICoreAssemblyMarker),
            typeof(IApiAssemblyMarker));
        services.AddEntityMapping<EntityMappingCollection>();
        services.AddMssqlIdentities();
        services.AddFiles();

        services.AddGraphQL()
            .AddProjections()
            .AddFiltering()
            .AddSorting()
            .RegisterDbContext()
            .AddQueryType<GraphQLQuery>()
            .AddMutationType<GraphQLMutation>();

        services.AddMediatR(typeof(ICoreAssemblyMarker));
        services.AddValidation();
        services.AddLocalizations(options =>
        {
            options.AddCultures(
                CultureInfo.GetCultureInfo("en-US"),
                CultureInfo.GetCultureInfo("uk-UA"));
            options.FromJson(x => x.Package = "Darnytsia.Creatio");
        });
        services.AddDarnytsiaBus();
        services.AddProcessEngines();
    }

    public override void Configure(IApplication app)
    {
        base.Configure(app);
        app.UseEntityCodeGen<IDataAssemblyMarker>();
        app.UseSwagger("Darnytsia");
        app.ConfigureMassTransit();
    }
}

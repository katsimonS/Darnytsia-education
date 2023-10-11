using Darnytsia.Creatio.Abstractions;
using Edenlab.Creatio.Abstractions;
using Edenlab.Creatio.EF;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Darnytsia.Creatio.Infrastructure.Persistence;

public class DarnytsiaDbContext : DbContext, IDbContext
{
    public DarnytsiaDbContext(
        IServiceProvider serviceProvider,
        IUserContext userContext)
        : base(serviceProvider, userContext)
    {
    }

    public override async Task SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        try
        {
            await base.SaveChangesAsync(cancellationToken);
        }
        catch
        {
            ChangeTracker.Reset();
        }
    }
}

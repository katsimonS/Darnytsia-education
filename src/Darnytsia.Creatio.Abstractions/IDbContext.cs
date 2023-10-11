using Edenlab.Creatio.EF.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace Darnytsia.Creatio.Abstractions;

public interface IDbContext
{
    IDatabaseFacade Database { get; }
    Task SaveChangesAsync(CancellationToken cancellationToken = default);
}

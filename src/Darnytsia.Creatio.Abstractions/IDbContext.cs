using Darnytsia.Creatio.Data.Entities;
using Edenlab.Creatio.EF;
using Edenlab.Creatio.EF.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace Darnytsia.Creatio.Abstractions;

public interface IDbContext
{
    IDatabaseFacade Database { get; }

    DbSet<Contact> Contacts { get; }
    DbSet<EdlBook> Books { get; }
    DbSet<EdlBookAuthor> BookAuthors { get; }

    Task SaveChangesAsync(CancellationToken cancellationToken = default);
}

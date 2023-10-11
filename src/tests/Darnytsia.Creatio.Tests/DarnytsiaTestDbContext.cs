using Darnytsia.Creatio.Abstractions;
using Edenlab.Creatio.EF.InMemory;

namespace Darnytsia.Creatio.Tests;

public class DarnytsiaTestDbContext : InMemoryDbContext, IDbContext
{
}

using Darnytsia.Creatio.Abstractions;
using Darnytsia.Creatio.Core.Features.Books.Queries;
using Darnytsia.Creatio.Data.Entities;
using System.Linq;
using System.Threading;

namespace Darnytsia.Creatio.Core.Features.Books.Handlers;

public class GetBookByIdHandler : IRequestHandler<GetBookByIdQuery, EdlBook>
{
    private readonly IDbContext _dbContext;

    public GetBookByIdHandler(IDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<EdlBook> Handle(GetBookByIdQuery request, CancellationToken cancellationToken)
    {
        return (await _dbContext.Books.FindAsync(request.BookId))!;
    }
}

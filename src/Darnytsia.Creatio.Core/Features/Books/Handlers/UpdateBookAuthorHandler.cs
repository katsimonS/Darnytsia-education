using Darnytsia.Creatio.Abstractions;
using Darnytsia.Creatio.Core.Features.Books.Commands;
using Darnytsia.Creatio.Data.Entities;
using Darnytsia.Creatio.Data;
using System.Linq;
using System.Threading;

namespace Darnytsia.Creatio.Core.Features.Books.Handlers;

public class UpdateBookAuthorHandler : IRequestHandler<FillingBookAuthorsCommand>
{
    private readonly IDbContext _dbContext;

    public UpdateBookAuthorHandler(IDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Unit> Handle(FillingBookAuthorsCommand request, CancellationToken cancellationToken)
    {
        var customers = await _dbContext.Contacts
            .AsNoTracking()
            .Where(x => x.TypeId == DbConst.Contact.Type.Customer)
            .ToListAsync(cancellationToken: cancellationToken);

        foreach (var contact in customers)
        {
            _dbContext.BookAuthors.Add(new EdlBookAuthor()
            {
                EdlBookId = request.BookId,
                EdlAuthorId = contact.Id
            });
        }

        await _dbContext.SaveChangesAsync(cancellationToken);
        return Unit.Value;
    }
}

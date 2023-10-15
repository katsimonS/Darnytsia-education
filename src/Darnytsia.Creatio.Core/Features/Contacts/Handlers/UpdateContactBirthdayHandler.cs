using Darnytsia.Creatio.Abstractions;
using Darnytsia.Creatio.Core.Features.Contacts.Commands;
using System.Linq;
using System.Threading;
using Unit = MediatR.Unit;

namespace Darnytsia.Creatio.Core.Features.Contacts.Handlers;

public class UpdateContactBirthdayHandler : IRequestHandler<UpdateContactBirthDayCommand>
{
    private readonly IDbContext _dbContext;

    public UpdateContactBirthdayHandler(IDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Unit> Handle(UpdateContactBirthDayCommand request, CancellationToken cancellationToken)
    {
        var contact = await _dbContext.Contacts.FindAsync(request.ContactId, cancellationToken: cancellationToken);
        contact!.BirthDate = request.BDay;
        await _dbContext.SaveChangesAsync(cancellationToken);
        return Unit.Value;
    }
}

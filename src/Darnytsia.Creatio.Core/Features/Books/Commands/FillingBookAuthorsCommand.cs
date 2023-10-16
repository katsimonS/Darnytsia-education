using System;

namespace Darnytsia.Creatio.Core.Features.Books.Commands;

public record FillingBookAuthorsCommand(Guid BookId) : IRequest;

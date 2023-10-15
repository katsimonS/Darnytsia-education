using System;

namespace Darnytsia.Creatio.Core.Features.Books.Commands;

public record UpdateBookAuthorCommand(Guid BookId) : IRequest;

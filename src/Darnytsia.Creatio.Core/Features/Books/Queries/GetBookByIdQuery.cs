using Darnytsia.Creatio.Data.Entities;
using System;

namespace Darnytsia.Creatio.Core.Features.Books.Queries;

public record GetBookByIdQuery(Guid BookId) : IRequest<EdlBook>;

using Darnytsia.Creatio.Data.Entities;
using System;

namespace Darnytsia.Creatio.Core.Features.Contacts.Queries;

public record GetContactBirthDayByIdQuery(Guid ContactId) : IRequest<string>;

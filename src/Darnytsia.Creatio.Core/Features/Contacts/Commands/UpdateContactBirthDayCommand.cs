using System;

namespace Darnytsia.Creatio.Core.Features.Contacts.Commands;

public record UpdateContactBirthDayCommand(Guid ContactId, DateTime Birthday) : IRequest;

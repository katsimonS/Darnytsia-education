using Darnytsia.Creatio.Contracts.Contacts;
using Darnytsia.Creatio.Core.Features.Contacts.Commands;
using Darnytsia.Creatio.Core.Features.Contacts.Queries;
using Edenlab.Creatio.Web.AspNet;
using MediatR;
using Swashbuckle.Swagger.Annotations;
using System;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;

namespace Darnytsia.Creatio.Api.Controllers;

[RoutePrefix("api/contacts")]
public class ContactsController : ApiControllerBase
{
    private readonly IMediator _mediator;

    public ContactsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    [Route("{contactId}")]
    [SwaggerResponse(HttpStatusCode.OK)]
    public async Task<IHttpActionResult> GetByIdAsync([FromUri] Guid contactId)
    {
        return Ok(await _mediator.Send(new GetContactBirthDayByIdQuery(contactId)));
    }

    [HttpPost]
    [Route("{contactId}/update-birthday")]
    [SwaggerResponse(HttpStatusCode.Created, Type = typeof(ContactRequest))]
    public async Task<IHttpActionResult> UpdateBirthdayAsync([FromUri]Guid contactId, [FromBody]ContactRequest contact)
    {
        await _mediator.Send(new UpdateContactBirthDayCommand(contactId, contact.BirthDay));
        return Accepted();
    }
}

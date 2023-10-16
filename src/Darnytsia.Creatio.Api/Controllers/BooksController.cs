using Darnytsia.Creatio.Core.Features.Books.Commands;
using Darnytsia.Creatio.Core.Features.Books.Queries;
using Edenlab.Creatio.Web.AspNet;
using MediatR;
using Swashbuckle.Swagger.Annotations;
using System;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;

namespace Darnytsia.Creatio.Api.Controllers;

[RoutePrefix("api/books")]
public class BooksController : ApiControllerBase
{
    private readonly IMediator _mediator;

    public BooksController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    [Route("{bookId}")]
    public async Task<IHttpActionResult> GetBookByIdAsync([FromUri] Guid bookId)
    {
        return Ok(await _mediator.Send(new GetBookByIdQuery(bookId)));
    }

    [HttpPost]
    [Route("{bookId}/update")]
    [SwaggerResponse(HttpStatusCode.Created)]
    public async Task<IHttpActionResult> Update([FromUri]Guid bookId)
    {
        await _mediator.Send(new UpdateBookAuthorCommand(bookId));
        return Accepted();
    }
}

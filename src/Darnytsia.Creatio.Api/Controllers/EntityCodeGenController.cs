using Darnytsia.Creatio.Data;
using Edenlab.Creatio.Abstractions;
using Edenlab.Creatio.Entities.Generation;
using Edenlab.Creatio.Web.AspNet;
using Swashbuckle.Swagger.Annotations;
using System.Net;
using System.Web.Http;

namespace Darnytsia.Creatio.Api.Controllers;

[RoutePrefix("api/entities/code-gen")]
public class EntityCodeGenController : ApiControllerBase
{
    private readonly IEntitySchemaManager _entitySchemaManager;
    private readonly IEntityFileService _entityFileService;

    public EntityCodeGenController(
        IEntitySchemaManager entitySchemaManager,
        IEntityFileService entityFileService)
    {
        _entitySchemaManager = entitySchemaManager;
        _entityFileService = entityFileService;
    }

    [HttpPost]
    [Route("{entityName}")]
    [SwaggerResponse(HttpStatusCode.OK)]
    public IHttpActionResult GenerateFile(string entityName)
    {
        var schema = _entitySchemaManager.GetSchemaByName(entityName);
        _entityFileService.GenerateFile(schema, typeof(IDataAssemblyMarker).Assembly);
        return Ok();
    }
}

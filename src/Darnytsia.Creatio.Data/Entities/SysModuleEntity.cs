namespace Darnytsia.Creatio.Data.Entities;

public partial record SysModuleEntity : BaseEntity
{
    public Guid? TypeColumnUId { get; set; }

    public Guid? SysEntitySchemaUId { get; set; }
}

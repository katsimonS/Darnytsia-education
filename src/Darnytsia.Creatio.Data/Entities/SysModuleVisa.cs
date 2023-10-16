namespace Darnytsia.Creatio.Data.Entities;

public partial record SysModuleVisa : BaseEntity
{
    public bool UseCustomNotificationProvider { get; set; }

    public Guid? VisaSchemaUId { get; set; }

    public Guid? MasterColumnUId { get; set; }
}

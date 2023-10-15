namespace Darnytsia.Creatio.Data.Entities;

public partial record SysModuleFolderMode : BaseEntity
{
    public string? Name { get; set; }

    public string? Code { get; set; }

    public override string ToString() => Name!;
}

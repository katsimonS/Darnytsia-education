namespace Darnytsia.Creatio.Data.Entities;

public partial record BaseLookup : BaseEntity
{
    public string? Name { get; set; }

    public string? Description { get; set; }

    public override string ToString() => Name!;
}

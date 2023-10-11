namespace Darnytsia.Creatio.Data.Entities;

public partial record Contact : BaseEntity
{
    public string? Name { get; set; }

    public override string ToString() => Name!;
}

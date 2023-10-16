namespace Darnytsia.Creatio.Data.Entities;

public partial record AccountEmployeesNumber : BaseLookup
{
    public int Position { get; set; }

    public override string ToString() => Name!;
}

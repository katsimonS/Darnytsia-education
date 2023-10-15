namespace Darnytsia.Creatio.Data.Entities;

public partial record AccountCategory : BaseLookup
{
    public override string ToString() => Name!;
}

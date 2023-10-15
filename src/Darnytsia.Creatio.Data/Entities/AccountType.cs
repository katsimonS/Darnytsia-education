namespace Darnytsia.Creatio.Data.Entities;

public partial record AccountType : BaseLookup
{
    public override string ToString() => Name!;
}

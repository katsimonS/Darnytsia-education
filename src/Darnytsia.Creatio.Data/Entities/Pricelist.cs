namespace Darnytsia.Creatio.Data.Entities;

public partial record Pricelist : BaseLookup
{
    public override string ToString() => Name!;
}

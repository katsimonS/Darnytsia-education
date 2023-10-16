namespace Darnytsia.Creatio.Data.Entities;

public partial record Gender : BaseLookup
{
    public override string ToString() => Name!;
}

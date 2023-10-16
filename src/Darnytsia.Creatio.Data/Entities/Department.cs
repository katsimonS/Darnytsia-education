namespace Darnytsia.Creatio.Data.Entities;

public partial record Department : BaseLookup
{
    public override string ToString() => Name!;
}

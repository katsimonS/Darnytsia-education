namespace Darnytsia.Creatio.Data.Entities;

public partial record Job : BaseLookup
{
    public override string ToString() => Name!;
}

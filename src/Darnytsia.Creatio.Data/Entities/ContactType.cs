namespace Darnytsia.Creatio.Data.Entities;

public partial record ContactType : BaseLookup
{
    public override string ToString() => Name!;
}

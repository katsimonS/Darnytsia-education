namespace Darnytsia.Creatio.Data.Entities;

public partial record AccountOwnership : BaseLookup
{
    public Guid? CountryId { get; set; }

    public override string ToString() => Name!;
}

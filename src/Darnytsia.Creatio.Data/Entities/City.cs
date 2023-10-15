namespace Darnytsia.Creatio.Data.Entities;

public partial record City : BaseLookup
{
    public Guid? CountryId { get; set; }

    public Guid? RegionId { get; set; }

    public Guid? TimeZoneId { get; set; }

    public override string ToString() => Name!;
}

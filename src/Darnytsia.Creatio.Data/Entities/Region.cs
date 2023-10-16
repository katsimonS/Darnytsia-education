namespace Darnytsia.Creatio.Data.Entities;

public partial record Region : BaseLookup
{
    public Guid? CountryId { get; set; }

    public Guid? TimeZoneId { get; set; }

    public string? Code { get; set; }

    public override string ToString() => Name!;
}

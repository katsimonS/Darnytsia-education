namespace Darnytsia.Creatio.Data.Entities;

public partial record Country : BaseImageLookup
{
    public string? BillingInfo { get; set; }

    public Guid? TimeZoneId { get; set; }

    public string? Code { get; set; }

    public string? Alpha2Code { get; set; }

    public override string ToString() => Name!;
}

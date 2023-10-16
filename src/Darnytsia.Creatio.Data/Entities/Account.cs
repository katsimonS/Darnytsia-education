namespace Darnytsia.Creatio.Data.Entities;

public partial record Account : BaseEntity
{
    public string? Name { get; set; }

    public Guid? OwnerId { get; set; }

    public Guid? OwnershipId { get; set; }

    public Guid? PrimaryContactId { get; set; }

    public Guid? ParentId { get; set; }

    public Guid? IndustryId { get; set; }

    public string? Code { get; set; }

    public Guid? TypeId { get; set; }

    public string? Phone { get; set; }

    public string? AdditionalPhone { get; set; }

    public string? Fax { get; set; }

    public string? Web { get; set; }

    public Guid? AddressTypeId { get; set; }

    public string? Address { get; set; }

    public Guid? CityId { get; set; }

    public Guid? RegionId { get; set; }

    public string? Zip { get; set; }

    public Guid? CountryId { get; set; }

    public Guid? AccountCategoryId { get; set; }

    public Guid? EmployeesNumberId { get; set; }

    public Guid? AnnualRevenueId { get; set; }

    public string? Notes { get; set; }

    public byte[] Logo { get; set; } = null!;

    public string? AlternativeName { get; set; }

    public string? GPSN { get; set; }

    public string? GPSE { get; set; }

    public Guid? PriceListId { get; set; }

    public int Completeness { get; set; }

    public Guid? AccountLogoId { get; set; }

    public string? AUM { get; set; }

    public override string ToString() => Name!;
}

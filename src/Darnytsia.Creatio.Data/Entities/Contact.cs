namespace Darnytsia.Creatio.Data.Entities;

public partial record Contact : BaseEntity
{
    public string? Name { get; set; }

    public Guid? OwnerId { get; set; }

    public string? Dear { get; set; }

    public Guid? SalutationTypeId { get; set; }

    public Guid? GenderId { get; set; }

    public Guid? AccountId { get; set; }

    public Guid? DecisionRoleId { get; set; }

    public Guid? TypeId { get; set; }

    public Guid? JobId { get; set; }

    public string? JobTitle { get; set; }

    public Guid? DepartmentId { get; set; }

    public DateTime? BirthDate { get; set; }

    public string? Phone { get; set; }

    public string? MobilePhone { get; set; }

    public string? HomePhone { get; set; }

    public string? Skype { get; set; }

    public string? Email { get; set; }

    public Guid? AddressTypeId { get; set; }

    public string? Address { get; set; }

    public Guid? CityId { get; set; }

    public Guid? RegionId { get; set; }

    public string? Zip { get; set; }

    public Guid? CountryId { get; set; }

    public bool DoNotUseEmail { get; set; }

    public bool DoNotUseCall { get; set; }

    public bool DoNotUseFax { get; set; }

    public bool DoNotUseSms { get; set; }

    public bool DoNotUseMail { get; set; }

    public string? Notes { get; set; }

    public string? Facebook { get; set; }

    public string? LinkedIn { get; set; }

    public string? Twitter { get; set; }

    public string? FacebookId { get; set; }

    public string? LinkedInId { get; set; }

    public string? TwitterId { get; set; }

    public byte[] ContactPhoto { get; set; } = null!;

    public Guid? TwitterAFDAId { get; set; }

    public Guid? FacebookAFDAId { get; set; }

    public Guid? LinkedInAFDAId { get; set; }

    public Guid? PhotoId { get; set; }

    public string? GPSN { get; set; }

    public string? GPSE { get; set; }

    public string? Surname { get; set; }

    public string? GivenName { get; set; }

    public string? MiddleName { get; set; }

    public bool Confirmed { get; set; }

    public bool IsNonActualEmail { get; set; }

    public int Completeness { get; set; }

    public Guid? LanguageId { get; set; }

    public int Age { get; set; }

    public bool IsEmailConfirmed { get; set; }

    public override string ToString() => Name!;
}

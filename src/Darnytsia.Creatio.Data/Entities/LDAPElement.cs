namespace Darnytsia.Creatio.Data.Entities;

public partial record LDAPElement : BaseLookup
{
    public string? LDAPEntryId { get; set; }

    public string? LDAPEntryDN { get; set; }

    public int Type { get; set; }

    public string? FullName { get; set; }

    public string? Company { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string? JobTitle { get; set; }

    public bool IsActive { get; set; }

    public override string ToString() => Name!;
}

namespace Darnytsia.Creatio.Data.Entities;

public partial record CommunicationType : BaseImageLookup
{
    public string? HyperlinkTemplate { get; set; }

    public bool UseforAccounts { get; set; }

    public bool UseforContacts { get; set; }

    public Guid? ImageLinkId { get; set; }

    public string? DisplayFormat { get; set; }

    public override string ToString() => Name!;
}

namespace Darnytsia.Creatio.Data.Entities;

public partial record SocialAccount : BaseEntityNotes
{
    public string? Login { get; set; }

    public bool Public { get; set; }

    public string? AccessToken { get; set; }

    public string? AccessSecretToken { get; set; }

    public string? ConsumerKey { get; set; }

    public Guid? TypeId { get; set; }

    public Guid? UserId { get; set; }

    public string? SocialId { get; set; }

    public bool IsExpired { get; set; }

    public string? Name { get; set; }

    public override string ToString() => Login!;
}

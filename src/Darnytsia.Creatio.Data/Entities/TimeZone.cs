namespace Darnytsia.Creatio.Data.Entities;

public partial record TimeZone : BaseCodeLookup
{
    public string? Offset { get; set; }

    public string? CodeAmerican { get; set; }

    public override string ToString() => Name!;
}

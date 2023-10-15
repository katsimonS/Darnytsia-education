namespace Darnytsia.Creatio.Data.Entities;

public partial record BaseCodeLookup : BaseLookup
{
    public string? Code { get; set; }

    public override string ToString() => Name!;
}

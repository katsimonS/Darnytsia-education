namespace Darnytsia.Creatio.Data.Entities;

public partial record BaseImageLookup : BaseLookup
{
    public byte[] Image { get; set; } = null!;

    public override string ToString() => Name!;
}

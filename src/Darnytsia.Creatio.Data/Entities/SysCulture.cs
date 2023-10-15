namespace Darnytsia.Creatio.Data.Entities;

public partial record SysCulture : BaseLookup
{
    public Guid? ImageId { get; set; }

    public bool Active { get; set; }

    public int Index { get; set; }

    public Guid? LanguageId { get; set; }

    public bool Default { get; set; }

    public override string ToString() => Name!;
}

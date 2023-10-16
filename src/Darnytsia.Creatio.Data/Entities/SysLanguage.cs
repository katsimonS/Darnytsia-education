namespace Darnytsia.Creatio.Data.Entities;

public partial record SysLanguage : BaseCodeLookup
{
    public bool IsUsed { get; set; }

    public override string ToString() => Name!;
}

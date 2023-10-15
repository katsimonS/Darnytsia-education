namespace Darnytsia.Creatio.Data.Entities;

public partial record AccountAnnualRevenue : BaseLookup
{
    public int FromBaseCurrency { get; set; }

    public int ToBaseCurrency { get; set; }

    public override string ToString() => Name!;
}

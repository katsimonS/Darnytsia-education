namespace Darnytsia.Creatio.Data.Entities;

public partial record AddressType : BaseLookup
{
    public bool ForContact { get; set; }

    public bool ForAccount { get; set; }

    public override string ToString() => Name!;
}

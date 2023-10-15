#nullable enable
namespace Darnytsia.Creatio.Data.Entities;

public partial record AccountOwnership
{
    private Country? _country;

    public Country? Country
    {
        get => _country;
        set
        {
            ChangedLinked.Value.Add(value!);
            CountryId = value!.Id;
            _country = value;
        }
    }
}
#nullable disable

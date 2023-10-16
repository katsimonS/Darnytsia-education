#nullable enable
namespace Darnytsia.Creatio.Data.Entities;

public partial record Region
{
    private Country? _country;
    private TimeZone? _timeZone;

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
    public TimeZone? TimeZone
    {
        get => _timeZone;
        set
        {
            ChangedLinked.Value.Add(value!);
            TimeZoneId = value!.Id;
            _timeZone = value;
        }
    }
}
#nullable disable

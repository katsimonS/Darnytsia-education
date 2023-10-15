#nullable enable
namespace Darnytsia.Creatio.Data.Entities;

public partial record City
{
    private Country? _country;
    private Region? _region;
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
    public Region? Region
    {
        get => _region;
        set
        {
            ChangedLinked.Value.Add(value!);
            RegionId = value!.Id;
            _region = value;
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

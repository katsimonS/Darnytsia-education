#nullable enable
namespace Darnytsia.Creatio.Data.Entities;

public partial record Country
{
    private TimeZone? _timeZone;

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

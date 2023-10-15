#nullable enable
namespace Darnytsia.Creatio.Data.Entities;

public partial record SocialAccount
{
    private CommunicationType? _type;
    private SysAdminUnit? _user;

    public CommunicationType? Type
    {
        get => _type;
        set
        {
            ChangedLinked.Value.Add(value!);
            TypeId = value!.Id;
            _type = value;
        }
    }
    public SysAdminUnit? User
    {
        get => _user;
        set
        {
            ChangedLinked.Value.Add(value!);
            UserId = value!.Id;
            _user = value;
        }
    }
}
#nullable disable

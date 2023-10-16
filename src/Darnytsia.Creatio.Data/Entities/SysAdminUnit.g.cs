#nullable enable
namespace Darnytsia.Creatio.Data.Entities;

public partial record SysAdminUnit
{
    private SysAdminUnit? _parentRole;
    private Contact? _contact;
    private Account? _account;
    private SysCulture? _sysCulture;
    private SysModule? _homePage;
    private SysLanguage? _dateTimeFormat;
    private Account? _portalAccount;
    private LDAPElement? _lDAPElement;

    public SysAdminUnit? ParentRole
    {
        get => _parentRole;
        set
        {
            ChangedLinked.Value.Add(value!);
            ParentRoleId = value!.Id;
            _parentRole = value;
        }
    }
    public Contact? Contact
    {
        get => _contact;
        set
        {
            ChangedLinked.Value.Add(value!);
            ContactId = value!.Id;
            _contact = value;
        }
    }
    public Account? Account
    {
        get => _account;
        set
        {
            ChangedLinked.Value.Add(value!);
            AccountId = value!.Id;
            _account = value;
        }
    }
    public SysCulture? SysCulture
    {
        get => _sysCulture;
        set
        {
            ChangedLinked.Value.Add(value!);
            SysCultureId = value!.Id;
            _sysCulture = value;
        }
    }
    public SysModule? HomePage
    {
        get => _homePage;
        set
        {
            ChangedLinked.Value.Add(value!);
            HomePageId = value!.Id;
            _homePage = value;
        }
    }
    public SysLanguage? DateTimeFormat
    {
        get => _dateTimeFormat;
        set
        {
            ChangedLinked.Value.Add(value!);
            DateTimeFormatId = value!.Id;
            _dateTimeFormat = value;
        }
    }
    public Account? PortalAccount
    {
        get => _portalAccount;
        set
        {
            ChangedLinked.Value.Add(value!);
            PortalAccountId = value!.Id;
            _portalAccount = value;
        }
    }
    public LDAPElement? LDAPElement
    {
        get => _lDAPElement;
        set
        {
            ChangedLinked.Value.Add(value!);
            LDAPElementId = value!.Id;
            _lDAPElement = value;
        }
    }
}
#nullable disable

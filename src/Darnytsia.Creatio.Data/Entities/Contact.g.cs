#nullable enable
namespace Darnytsia.Creatio.Data.Entities;

public partial record Contact
{
    private Contact? _owner;
    private ContactSalutationType? _salutationType;
    private Gender? _gender;
    private Account? _account;
    private ContactDecisionRole? _decisionRole;
    private ContactType? _type;
    private Job? _job;
    private Department? _department;
    private AddressType? _addressType;
    private City? _city;
    private Region? _region;
    private Country? _country;
    private SocialAccount? _twitterAFDA;
    private SocialAccount? _facebookAFDA;
    private SocialAccount? _linkedInAFDA;
    private SysImage? _photo;
    private SysLanguage? _language;

    public Contact? Owner
    {
        get => _owner;
        set
        {
            ChangedLinked.Value.Add(value!);
            OwnerId = value!.Id;
            _owner = value;
        }
    }
    public ContactSalutationType? SalutationType
    {
        get => _salutationType;
        set
        {
            ChangedLinked.Value.Add(value!);
            SalutationTypeId = value!.Id;
            _salutationType = value;
        }
    }
    public Gender? Gender
    {
        get => _gender;
        set
        {
            ChangedLinked.Value.Add(value!);
            GenderId = value!.Id;
            _gender = value;
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
    public ContactDecisionRole? DecisionRole
    {
        get => _decisionRole;
        set
        {
            ChangedLinked.Value.Add(value!);
            DecisionRoleId = value!.Id;
            _decisionRole = value;
        }
    }
    public ContactType? Type
    {
        get => _type;
        set
        {
            ChangedLinked.Value.Add(value!);
            TypeId = value!.Id;
            _type = value;
        }
    }
    public Job? Job
    {
        get => _job;
        set
        {
            ChangedLinked.Value.Add(value!);
            JobId = value!.Id;
            _job = value;
        }
    }
    public Department? Department
    {
        get => _department;
        set
        {
            ChangedLinked.Value.Add(value!);
            DepartmentId = value!.Id;
            _department = value;
        }
    }
    public AddressType? AddressType
    {
        get => _addressType;
        set
        {
            ChangedLinked.Value.Add(value!);
            AddressTypeId = value!.Id;
            _addressType = value;
        }
    }
    public City? City
    {
        get => _city;
        set
        {
            ChangedLinked.Value.Add(value!);
            CityId = value!.Id;
            _city = value;
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
    public SocialAccount? TwitterAFDA
    {
        get => _twitterAFDA;
        set
        {
            ChangedLinked.Value.Add(value!);
            TwitterAFDAId = value!.Id;
            _twitterAFDA = value;
        }
    }
    public SocialAccount? FacebookAFDA
    {
        get => _facebookAFDA;
        set
        {
            ChangedLinked.Value.Add(value!);
            FacebookAFDAId = value!.Id;
            _facebookAFDA = value;
        }
    }
    public SocialAccount? LinkedInAFDA
    {
        get => _linkedInAFDA;
        set
        {
            ChangedLinked.Value.Add(value!);
            LinkedInAFDAId = value!.Id;
            _linkedInAFDA = value;
        }
    }
    public SysImage? Photo
    {
        get => _photo;
        set
        {
            ChangedLinked.Value.Add(value!);
            PhotoId = value!.Id;
            _photo = value;
        }
    }
    public SysLanguage? Language
    {
        get => _language;
        set
        {
            ChangedLinked.Value.Add(value!);
            LanguageId = value!.Id;
            _language = value;
        }
    }
}
#nullable disable

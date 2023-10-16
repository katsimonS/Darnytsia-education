#nullable enable
namespace Darnytsia.Creatio.Data.Entities;

public partial record Account
{
    private Contact? _owner;
    private AccountOwnership? _ownership;
    private Contact? _primaryContact;
    private Account? _parent;
    private AccountIndustry? _industry;
    private AccountType? _type;
    private AddressType? _addressType;
    private City? _city;
    private Region? _region;
    private Country? _country;
    private AccountCategory? _accountCategory;
    private AccountEmployeesNumber? _employeesNumber;
    private AccountAnnualRevenue? _annualRevenue;
    private Pricelist? _priceList;
    private SysImage? _accountLogo;

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
    public AccountOwnership? Ownership
    {
        get => _ownership;
        set
        {
            ChangedLinked.Value.Add(value!);
            OwnershipId = value!.Id;
            _ownership = value;
        }
    }
    public Contact? PrimaryContact
    {
        get => _primaryContact;
        set
        {
            ChangedLinked.Value.Add(value!);
            PrimaryContactId = value!.Id;
            _primaryContact = value;
        }
    }
    public Account? Parent
    {
        get => _parent;
        set
        {
            ChangedLinked.Value.Add(value!);
            ParentId = value!.Id;
            _parent = value;
        }
    }
    public AccountIndustry? Industry
    {
        get => _industry;
        set
        {
            ChangedLinked.Value.Add(value!);
            IndustryId = value!.Id;
            _industry = value;
        }
    }
    public AccountType? Type
    {
        get => _type;
        set
        {
            ChangedLinked.Value.Add(value!);
            TypeId = value!.Id;
            _type = value;
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
    public AccountCategory? AccountCategory
    {
        get => _accountCategory;
        set
        {
            ChangedLinked.Value.Add(value!);
            AccountCategoryId = value!.Id;
            _accountCategory = value;
        }
    }
    public AccountEmployeesNumber? EmployeesNumber
    {
        get => _employeesNumber;
        set
        {
            ChangedLinked.Value.Add(value!);
            EmployeesNumberId = value!.Id;
            _employeesNumber = value;
        }
    }
    public AccountAnnualRevenue? AnnualRevenue
    {
        get => _annualRevenue;
        set
        {
            ChangedLinked.Value.Add(value!);
            AnnualRevenueId = value!.Id;
            _annualRevenue = value;
        }
    }
    public Pricelist? PriceList
    {
        get => _priceList;
        set
        {
            ChangedLinked.Value.Add(value!);
            PriceListId = value!.Id;
            _priceList = value;
        }
    }
    public SysImage? AccountLogo
    {
        get => _accountLogo;
        set
        {
            ChangedLinked.Value.Add(value!);
            AccountLogoId = value!.Id;
            _accountLogo = value;
        }
    }
}
#nullable disable

#nullable enable
namespace Darnytsia.Creatio.Data.Entities;

public partial record SysCulture
{
    private SysImage? _image;
    private SysLanguage? _language;

    public SysImage? Image
    {
        get => _image;
        set
        {
            ChangedLinked.Value.Add(value!);
            ImageId = value!.Id;
            _image = value;
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

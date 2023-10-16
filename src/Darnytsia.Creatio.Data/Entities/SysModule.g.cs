#nullable enable
namespace Darnytsia.Creatio.Data.Entities;

public partial record SysModule
{
    private SysModuleEntity? _sysModuleEntity;
    private SysModuleFolderMode? _folderMode;
    private SysImage? _image32;
    private SysImage? _logo;
    private SysModuleVisa? _sysModuleVisa;

    public SysModuleEntity? SysModuleEntity
    {
        get => _sysModuleEntity;
        set
        {
            ChangedLinked.Value.Add(value!);
            SysModuleEntityId = value!.Id;
            _sysModuleEntity = value;
        }
    }
    public SysModuleFolderMode? FolderMode
    {
        get => _folderMode;
        set
        {
            ChangedLinked.Value.Add(value!);
            FolderModeId = value!.Id;
            _folderMode = value;
        }
    }
    public SysImage? Image32
    {
        get => _image32;
        set
        {
            ChangedLinked.Value.Add(value!);
            Image32Id = value!.Id;
            _image32 = value;
        }
    }
    public SysImage? Logo
    {
        get => _logo;
        set
        {
            ChangedLinked.Value.Add(value!);
            LogoId = value!.Id;
            _logo = value;
        }
    }
    public SysModuleVisa? SysModuleVisa
    {
        get => _sysModuleVisa;
        set
        {
            ChangedLinked.Value.Add(value!);
            SysModuleVisaId = value!.Id;
            _sysModuleVisa = value;
        }
    }
}
#nullable disable

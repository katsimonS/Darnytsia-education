namespace Darnytsia.Creatio.Data.Entities;

public partial record SysModule : BaseEntity
{
    public string? Caption { get; set; }

    public Guid? SysModuleEntityId { get; set; }

    public byte[] Image16 { get; set; } = null!;

    public byte[] Image20 { get; set; } = null!;

    public Guid? FolderModeId { get; set; }

    public bool GlobalSearchAvailable { get; set; }

    public bool HasAnalytics { get; set; }

    public bool HasActions { get; set; }

    public bool HasRecent { get; set; }

    public string? Code { get; set; }

    public string? HelpContextId { get; set; }

    public string? ModuleHeader { get; set; }

    public string? Attribute { get; set; }

    public Guid? SysPageSchemaUId { get; set; }

    public Guid? CardSchemaUId { get; set; }

    public Guid? SectionModuleSchemaUId { get; set; }

    public Guid? SectionSchemaUId { get; set; }

    public Guid? CardModuleUId { get; set; }

    public Guid? TypeColumnValue { get; set; }

    public Guid? Image32Id { get; set; }

    public Guid? LogoId { get; set; }

    public Guid? SysModuleVisaId { get; set; }

    public bool IsSystem { get; set; }

    public int Type { get; set; }

    public string? Description { get; set; }

    public string? IconBackground { get; set; }

    public override string ToString() => Caption!;
}

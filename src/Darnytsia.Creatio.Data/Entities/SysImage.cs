namespace Darnytsia.Creatio.Data.Entities;

public partial record SysImage : BaseEntity
{
    public DateTime? UploadedOn { get; set; }

    public string? Name { get; set; }

    public byte[] Data { get; set; } = null!;

    public string? MimeType { get; set; }

    public bool HasRef { get; set; }

    public byte[] PreviewData { get; set; } = null!;

    public string? Hash { get; set; }

    public override string ToString() => Name!;
}

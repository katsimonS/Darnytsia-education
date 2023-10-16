#nullable enable
namespace Darnytsia.Creatio.Data.Entities;

public partial record CommunicationType
{
    private SysImage? _imageLink;

    public SysImage? ImageLink
    {
        get => _imageLink;
        set
        {
            ChangedLinked.Value.Add(value!);
            ImageLinkId = value!.Id;
            _imageLink = value;
        }
    }
}
#nullable disable

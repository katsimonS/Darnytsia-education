#nullable enable
namespace Darnytsia.Creatio.Data.Entities;

public partial record EdlBook
{
    private EdlCoverType? _edlBookCoverType;
    private EdlBookStatus? _edlBookStatus;

    public EdlCoverType? EdlBookCoverType
    {
        get => _edlBookCoverType;
        set
        {
            ChangedLinked.Value.Add(value!);
            EdlBookCoverTypeId = value!.Id;
            _edlBookCoverType = value;
        }
    }
    public EdlBookStatus? EdlBookStatus
    {
        get => _edlBookStatus;
        set
        {
            ChangedLinked.Value.Add(value!);
            EdlBookStatusId = value!.Id;
            _edlBookStatus = value;
        }
    }
}
#nullable disable

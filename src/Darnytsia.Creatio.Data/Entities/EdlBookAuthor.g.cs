#nullable enable
namespace Darnytsia.Creatio.Data.Entities;

public partial record EdlBookAuthor
{
    private EdlBook? _edlBook;
    private Contact? _edlAuthor;

    public EdlBook? EdlBook
    {
        get => _edlBook;
        set
        {
            ChangedLinked.Value.Add(value!);
            EdlBookId = value!.Id;
            _edlBook = value;
        }
    }
    public Contact? EdlAuthor
    {
        get => _edlAuthor;
        set
        {
            ChangedLinked.Value.Add(value!);
            EdlAuthorId = value!.Id;
            _edlAuthor = value;
        }
    }
}
#nullable disable

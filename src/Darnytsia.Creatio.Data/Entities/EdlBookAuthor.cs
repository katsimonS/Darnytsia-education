namespace Darnytsia.Creatio.Data.Entities;

public partial record EdlBookAuthor : BaseEntity
{
    public string? EdlName { get; set; }

    public Guid? EdlBookId { get; set; }

    public Guid? EdlAuthorId { get; set; }

    public override string ToString() => EdlName!;
}

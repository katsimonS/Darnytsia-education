namespace Darnytsia.Creatio.Data.Entities;

public partial record EdlBook : BaseEntity
{
    public string? EdlName { get; set; }

    public Guid? EdlBookCoverTypeId { get; set; }

    public Guid? EdlBookStatusId { get; set; }

    public string? EdlBookDescription { get; set; }

    public int EdlBookPageCount { get; set; }

    public DateTime? EdlBookPublishDate { get; set; }

    public override string ToString() => EdlName!;
}

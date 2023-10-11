namespace Darnytsia.Creatio.Data.Entities;

public partial record BaseEntity : Edenlab.Creatio.Entities.Models.BaseEntity
{
    public Guid? CreatedById { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? ModifiedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int ProcessListeners { get; set; }
}

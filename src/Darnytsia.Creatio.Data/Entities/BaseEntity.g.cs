namespace Darnytsia.Creatio.Data.Entities
{
    public partial record BaseEntity
    {
        private Contact _createdBy;
        private Contact _modifiedBy;

        public Contact CreatedBy
        {
            get => _createdBy;
            set
            {
                ChangedLinked.Value.Add(value);
                CreatedById = value.Id;
                _createdBy = value;
            }
        }

        public Contact ModifiedBy
        {
            get => _modifiedBy;
            set
            {
                ChangedLinked.Value.Add(value);
                ModifiedById = value.Id;
                _modifiedBy = value;
            }
        }
    }
}

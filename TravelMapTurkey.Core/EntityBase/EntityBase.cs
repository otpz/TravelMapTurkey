namespace TravelMapTurkey.Core.EntityBase
{
    public abstract class EntityBase : IEntityBase
    {
        public virtual int Id { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual DateTime DeletedDate { get; set; }
        public virtual bool IsDeleted { get; set; } 
    }
}

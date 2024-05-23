namespace TravelMapTurkey.Core.EntityBase
{
    public abstract class EntityBase : IEntityBase
    {
        public virtual int Id { get; set; }
        public virtual DateTime? CreatedDate { get; set; } = DateTime.Now;
        public virtual DateTime? DeletedDate { get; set; } = null;
        public virtual bool IsDeleted { get; set; } = false;
    }
}

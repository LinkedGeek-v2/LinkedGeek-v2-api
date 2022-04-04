using System.ComponentModel.DataAnnotations;

namespace LG.Domain.Common
{
    public class BaseEntity : IEntity<Guid>
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
    }

    public abstract class BaseAuditableEntity : BaseEntity, IAuditable
    {
        public string UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public abstract class BaseSoftDeleteEntity : BaseEntity, ISoftDelete
    {
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
    }

    public abstract class BaseAuditableSoftDeleteEntity : BaseSoftDeleteEntity, IAuditable
    {
        public string UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}

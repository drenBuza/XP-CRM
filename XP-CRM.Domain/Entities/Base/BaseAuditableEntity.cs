namespace XP_CRM.Domain.Entities.Base;

public abstract class BaseAuditableEntity : BaseEntity<Guid>
{
    public string CreatedBy { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public string? UpdatedBy { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public bool IsDeleted { get; set; } = false;
}
using XP_CRM.Domain.Entities.Base;

namespace XP_CRM.Domain.Entities;

public class Survey : BaseAuditableEntity
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public ICollection<Question> Questions { get; set; } = new List<Question>();
}
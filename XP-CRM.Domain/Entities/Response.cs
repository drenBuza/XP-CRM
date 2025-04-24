using XP_CRM.Domain.Entities.Base;

namespace XP_CRM.Domain.Entities;

public class Response : BaseAuditableEntity
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid SurveyId { get; set; }
    public string Email { get; set; } = string.Empty;
    public DateTime SubmittedAt { get; set; } = DateTime.UtcNow;
    public ICollection<ResponseItem> Answers { get; set; } = new List<ResponseItem>();

    public Survey? Survey { get; set; }
}
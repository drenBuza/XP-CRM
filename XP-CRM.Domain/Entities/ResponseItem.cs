using XP_CRM.Domain.Entities.Base;

namespace XP_CRM.Domain.Entities;

public class ResponseItem : BaseAuditableEntity
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid ResponseId { get; set; }
    public Guid QuestionId { get; set; }
    public string Answer { get; set; } = string.Empty;

    public Response? Response { get; set; }
    public Question? Question { get; set; }
}
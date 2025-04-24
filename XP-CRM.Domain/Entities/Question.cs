using XP_CRM.Domain.Entities.Base;
using XP_CRM.Domain.Enums;

namespace XP_CRM.Domain.Entities;

public class Question : BaseAuditableEntity
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid SurveyId { get; set; }
    public string Text { get; set; } = string.Empty;
    public QuestionType Type { get; set; } = QuestionType.Text;
    public bool IsRequired { get; set; } = false;

    public Survey? Survey { get; set; }
}
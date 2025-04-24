using XP_CRM.Domain.Enums;
using XP_CRM.Domain.Entities.Base;

namespace XP_CRM.Domain.Entities;

public class Applicant : BaseAuditableEntity
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid ResponseId { get; set; }
    public ApplicantStatus Status { get; set; } = ApplicantStatus.Pending;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public Response? Response { get; set; }
}
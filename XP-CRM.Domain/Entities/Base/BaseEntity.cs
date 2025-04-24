namespace XP_CRM.Domain.Entities.Base;

public abstract class BaseEntity<T>
{
    public T Id { get; set; } = default!;
}
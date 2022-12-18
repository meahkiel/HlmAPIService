namespace PMV.Core.BaseEntity;

[AuditableAttribute]
public class Entity
{
    public Guid Id { get; set; }

    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public string? CreatedBy { get; set; }
    public string? UpdatedBy { get; set; }
}

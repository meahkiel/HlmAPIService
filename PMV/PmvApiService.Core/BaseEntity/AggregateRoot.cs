namespace PMV.Core.BaseEntity;

[Auditable]
public abstract class AggregateRoot
{

    public AggregateRoot()
    {
        Id = Guid.NewGuid();
    }

    public Guid Id { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public string? CreatedBy { get; set; }
    public string? UpdatedBy { get; set; }

    public bool Active { get; set; } = true;

}
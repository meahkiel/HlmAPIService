using PMV.Core.BaseEntity;

namespace PMV.Core.Common.Locations;

public class ProjectLocation : AggregateRoot
{

    public ProjectLocation()
        : base()
    {

    }
    public string DepartmentName { get; set; } = "";
    public float SurCharge { get; set; } = 0;
}

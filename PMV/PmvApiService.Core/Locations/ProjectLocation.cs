using PMV.PmvApiService.Core.BaseEntity;

namespace PMV.PmvApiService.Core.Locations;

public class ProjectLocation : AggregateRoot
{

    public ProjectLocation()
        : base()
    {

    }
    public string DepartmentName { get; set; } = "";
    public float SurCharge { get; set; } = 0;
}

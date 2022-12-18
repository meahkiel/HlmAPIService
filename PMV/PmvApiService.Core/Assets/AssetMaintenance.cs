using PMV.Core.BaseEntity;

namespace PMV.Core.Assets;

public class AssetMaintenance : AggregateRoot
{

    public DateTime? LastServiceDate { get; set; }
    public DateTime? LastInspectionDate { get; set; }
    public int LastReading { get; set; }
    public string? LastReadingOn { get; set; }



}

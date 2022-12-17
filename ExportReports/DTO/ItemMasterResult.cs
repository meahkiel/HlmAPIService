namespace ExportReports.DTO;

public class ItemMasterResult
{
    public string ItemCode { get; set; }
    public string ItemDescription { get; set; }

    public decimal TotalQty => Details.Sum(c => c.Qty);

    public decimal TotalUnitRate => Details.Sum(c => c.UnitRate);

    public List<ItemMasterDetailResult> Details { get; set; } = new List<ItemMasterDetailResult>();

    public string Company { get; set; }
    public string Department { get; set; }
}


public class ItemMasterDetailResult {
    
    public string ReferenceNo { get; set; }
    public decimal Qty { get; set; }
    public decimal UnitRate { get; set; }

    public string UOM { get; set; }
    public string? TypeOfDoc { get; set; }
    public string? TypeOfDocPO { get; set; }
    


}
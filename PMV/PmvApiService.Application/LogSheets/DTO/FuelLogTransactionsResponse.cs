namespace PMV.PmvApiService.Application.LogSheets.DTO;

public class FuelLogTransactionsResponse
{
    public Guid LogSheetId { get; set; }
    public string ReferenceNo { get; set; } = "";
    public string AssetCode { get; set; } = "";
    public string Code { get; set; } = "";
    public string Location { get; set; } = "";
    public string FueledDate { get; set; } = "";
    public string FuelTime { get; set; } = "";
    
    public int StartShiftMeterReading { get; set; }

    public int EndShiftMeterReading { get; set; }

    public int Quantity { get; set; }
    public int Reading { get; set; }
    public int PreviousReading { get; set; }
    public decimal Diff => Reading - PreviousReading;
    public decimal LH => PreviousReading == 0 ? 0m : (Quantity / Diff);
    public decimal HL => PreviousReading == 0 ? 0m : (Diff / Quantity);
    public string LHFormat => LH.ToString("0.00");
    public string HLFormat => HL.ToString("0.00");
    public bool IsPosted { get; set; }
    public DateTime PostedAt { get; set; }
    public string Fueler { get; set; }

}
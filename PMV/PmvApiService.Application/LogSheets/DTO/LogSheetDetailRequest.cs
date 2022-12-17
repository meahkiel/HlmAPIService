namespace PMV.PmvApiService.Application.LogSheets.DTO;

public class LogSheetDetailRequest
{

    public string? Id { get; set; }

    public string LogSheetId { get; set; } = null!;

    public string AssetCode { get; set; } = "";
    public string FuelTime { get; set; } = "";
    public string? OperatorDriver { get; set; } = "";
    public int Reading { get; set; } = 0;
    public float Quantity { get; set; } = 0f;

    public string? DriverQatarIdUrl { get; set; }
    public string? CurrentSMUUrl { get; set; }
    public string? TankMeterUrl { get; set; }

    public string? UIState { get; set; }
}
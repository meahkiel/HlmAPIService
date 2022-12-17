namespace PMV.PmvApiService.Application.LogSheets.DTO; 

public record LogSheetOpenRequest(
    string FueledDate,
    string ShiftStartTime,
    int StartShiftTankerKm,
    int StartShiftMeterReading,
    string Location,
    string LVStation,
    string? Remarks,
    string EmployeeCode);

public record LogSheetCloseRequest(
    string Id,
    string ShiftEndTime,
    int EndShiftTankerKm,
    int EndShiftMeterReading,
    string EmployeeCode,
    string? Remarks
);

public record LogSheetRequest(
    string? Id,
    string ShiftEndTime,
    int EndShiftTankerKm,
    int EndShiftMeterReading,
    string EmployeeCode,
    string FueledDate,
    string ShiftStartTime,
    int StartShiftTankerKm,
    int StartShiftMeterReading,
    string Location,
    string LVStation,
    string? Remarks,
    string Fueler,
    ICollection<LogSheetDetailRequest>? details
);
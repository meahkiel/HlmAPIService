using MediatR;
using PMV.PmvApiService.Application.Core;
using PMV.PmvApiService.Application.Interfaces.Repositories;
using PMV.PmvApiService.Application.LogSheets.DTO;
using PMV.PmvApiService.Core.FuelLogs;

namespace PMV.PmvApiService.Application.LogSheets.Queries
{
    public class GetSingleLogSheet
    {
        public record Query(string Id) : IRequest<Result<LogSheetResponse>>;

        public class QueryHandler : IRequestHandler<Query, Result<LogSheetResponse>>
        {
            private readonly IUnitWork _context;

            public QueryHandler(IUnitWork context)
            {
                _context = context;

            }

            private IEnumerable<LogSheetDetailResponse> ExtractDetail(IEnumerable<LogSheetDetail> details) {
                var responses = new List<LogSheetDetailResponse>();
                
                foreach(var detail in details) {
                    responses.Add(new LogSheetDetailResponse {
                        Id = detail.Id.ToString(),
                        LogSheetId = detail.LogSheet.Id.ToString(),
                        AssetCode = detail.AssetCode,
                        FuelTime = detail.FuelTime,
                        OperatorDriver = detail.OperatorDriver,
                        Reading = detail.Reading,
                        PreviousReading = detail.PreviousReading,
                        Quantity = detail.Quantity,
                        DriverQatarIdUrl = detail.DriverQatarIdUrl,
                    });
                }

                return responses;
            }

            public async Task<Result<LogSheetResponse>> Handle(Query request, CancellationToken cancellationToken)
            {
                try {
                    var logsheet  = await _context.LogSheets.GetByIdAsync(Guid.Parse(request.Id));
                    
                    if(logsheet == null) 
                        throw new Exception("Cannot find Logsheet");
                    
                    return Result<LogSheetResponse>.Success(new LogSheetResponse 
                    {
                        Id = logsheet.Id.ToString(),
                        ReferenceNo = logsheet.ReferenceNo,
                        ShiftStartTime = logsheet.ShiftStartTime.ToLongTimeString(),
                        ShiftEndTime = logsheet.ShiftEndTime.HasValue ? logsheet.ShiftEndTime.Value.ToLongTimeString() : null,
                        StartShiftMeterReading = logsheet.StartShiftMeterReading,
                        EndShiftMeterReading = logsheet.EndShiftMeterReading ?? 0,
                        StartShiftTankerKm = logsheet.StartShiftTankerKm,
                        EndShiftTankerKm = logsheet.EndShiftTankerKm ?? 0,
                        FueledDate = logsheet.FueledDate,
                        EmployeeCode = logsheet.UpdatedBy!,
                        Location = logsheet.Location,
                        Remarks = logsheet.Remarks,
                        LVStation = logsheet.LVStation.Code,
                        Details = ExtractDetail(logsheet.Details).ToList()
                    });
                }
                catch(Exception ex) {
                    return Result<LogSheetResponse>.Failure(ex.Message);
                }

            }
        }

    }
}
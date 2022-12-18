using MediatR;
using PMV.Application.Interfaces;
using PMV.Application.LogSheets.DTO;
using PMV.Core.FuelLogs;
using Shared.Core;

namespace PMV.Application.LogSheets.Queries
{
    public class GetLogsheetsByStatus
    {
        public record Query(string LVStation, bool IsPosted) : IRequest<Result<IEnumerable<LogSheetResponse>>>;

        public class QueryHandler : IRequestHandler<Query, Result<IEnumerable<LogSheetResponse>>>
        {
            private readonly IUnitWork _context;

            public QueryHandler(IUnitWork context)
            {
                _context = context;
            }

            private IEnumerable<LogSheetDetailResponse> ExtractDetail(IEnumerable<LogSheetDetail> details)
            {

                var responses = new List<LogSheetDetailResponse>();

                foreach (var detail in details)
                {
                    responses.Add(new LogSheetDetailResponse
                    {
                        Id = detail.Id.ToString(),
                        AssetCode = detail.AssetCode,
                        FuelTime = detail.FuelTime,
                        OperatorDriver = detail.OperatorDriver,
                        Reading = detail.Reading,
                        PreviousReading = detail.PreviousReading,
                        Quantity = detail.Quantity,
                        DriverQatarIdUrl = detail.DriverQatarIdUrl
                    });
                }

                return responses;
            }


            public async Task<Result<IEnumerable<LogSheetResponse>>> Handle(Query request, CancellationToken cancellationToken)
            {
                try
                {

                    var logSheets = await _context.LogSheets
                                                .GetByLVStation(request.LVStation, request.IsPosted);

                    if (logSheets == null)
                        throw new Exception("Logsheets not found");

                    var responses = logSheets.Select(
                                                    sheet => new LogSheetResponse
                                                    {
                                                        Id = sheet.Id.ToString(),
                                                        FueledDate = sheet.FueledDate,
                                                        ReferenceNo = sheet.ReferenceNo,
                                                        ShiftStartTime = sheet.ShiftStartTime.ToShortTimeString(),
                                                        ShiftEndTime = sheet.ShiftEndTime.HasValue ? sheet.ShiftEndTime.Value.ToShortTimeString() : null,
                                                        StartShiftTankerKm = sheet.StartShiftTankerKm,
                                                        EndShiftTankerKm = sheet.EndShiftTankerKm,
                                                        StartShiftMeterReading = sheet.StartShiftMeterReading,
                                                        EndShiftMeterReading = sheet.EndShiftMeterReading,
                                                        Location = sheet.Location,
                                                        LVStation = sheet.LVStation.Code,
                                                        Remarks = sheet.Remarks,
                                                        EmployeeCode = sheet.CreatedBy ?? "",
                                                        Details = ExtractDetail(sheet.Details).ToList()
                                                    }).ToList();

                    return Result<IEnumerable<LogSheetResponse>>.Success(responses);
                }
                catch (Exception ex)
                {
                    return Result<IEnumerable<LogSheetResponse>>.Failure(ex.Message);
                }
            }
        }
    }
}
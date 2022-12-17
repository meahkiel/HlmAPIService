using MediatR;
using PMV.PmvApiService.Core.FuelLogs;
using PmvApiService.Application.Common.Exceptions.FuelExceptions;
using PMV.PmvApiService.Application.Core;
using PMV.PmvApiService.Application.Interfaces.Repositories;
using PMV.PmvApiService.Application.LogSheets.DTO;
using Microsoft.EntityFrameworkCore;

namespace PMV.PmvApiService.Application.LogSheets.Commands
{
    public class CreateFullRecord
    {
        public record Command(LogSheetRequest SheetRequest) : IRequest<Result<LogSheetResponse>>;

        public class CommandHandler : IRequestHandler<Command, Result<LogSheetResponse>>
        {
            private readonly IUnitWork _context;
            public CommandHandler(IUnitWork context)
            {
                _context = context;
            }

            private async Task<LogSheetDetail> GetPreviousRecord(string assetCode,int reading)
            {
                //check the previous record
                var previousRecord = await _context.GetContext()
                                        .LogSheetDetails.Where(d => d.AssetCode == assetCode)
                                        .OrderByDescending(l => l.LogSheet.CreatedAt)
                                        .FirstOrDefaultAsync() ?? new LogSheetDetail();

                if (reading < previousRecord.Reading) {
                    throw new ReadingException();
                }

                return previousRecord;
            }



            public async Task<Result<LogSheetResponse>> Handle(Command request, CancellationToken cancellationToken)
            {
                try
                {

                    LogSheet? logSheet = null;
                    LogSheetResponse response = new LogSheetResponse();

                    var lvStation = await _context.GetContext().LVStations
                                            .SingleOrDefaultAsync(v => v.Code == request.SheetRequest.LVStation);

                    if (lvStation == null) throw new Exception("Invalid LV Station");

                    //check if exist
                    if (!string.IsNullOrEmpty(request.SheetRequest.Id)) {
                        logSheet = await _context.LogSheets.GetByIdAsync(Guid.Parse(request.SheetRequest.Id));
                        if(logSheet == null)  throw new Exception("Logsheet not found");

                        logSheet!.FueledDate = DateTime.Parse(request.SheetRequest.FueledDate);
                        logSheet!.ShiftStartTime = DateTime.Parse(request.SheetRequest.ShiftStartTime);
                        logSheet!.ShiftEndTime = DateTime.Parse(request.SheetRequest.ShiftEndTime);
                        logSheet!.StartShiftTankerKm = request.SheetRequest.StartShiftTankerKm;
                        logSheet!.EndShiftTankerKm = request.SheetRequest.EndShiftTankerKm;
                        logSheet!.StartShiftMeterReading = request.SheetRequest.StartShiftMeterReading;
                        logSheet!.EndShiftMeterReading = request.SheetRequest.EndShiftMeterReading;
                        logSheet!.Location = request.SheetRequest.Location;
                        logSheet!.LVStation = lvStation;
                        logSheet!.CreatedBy = request.SheetRequest.Fueler;
                        logSheet!.CreatedAt = DateTime.Today;
                        logSheet!.UpdatedBy = request.SheetRequest.EmployeeCode;
                        logSheet!.UpdatedAt = DateTime.Today;

                        if(request.SheetRequest.details != null && request.SheetRequest.details.Count > 0) {
                            
                            foreach(var detail in request.SheetRequest.details) {
                                var existingDetail = logSheet.Details.Where(d => d.Id == Guid.Parse(detail.Id!)).SingleOrDefault();
                                
                                if(existingDetail == null) {

                                    var prevRecord = await GetPreviousRecord(detail.AssetCode,detail.Reading);
                                    var logSheetDetail = LogSheetDetail.CreateNoAutoId(
                                            id: detail.Id!,
                                            logSheet: logSheet,
                                            assetCode: detail.AssetCode,
                                            fuelTime: DateTime.Parse(detail.FuelTime),
                                            reading: detail.Reading,
                                            previousReading: prevRecord.Reading,
                                            quantity: detail.Quantity,
                                            driverQatarIdUrl: detail.DriverQatarIdUrl ?? "",
                                            currentSMUUrl: detail.CurrentSMUUrl ?? "",
                                            tankMeterUrl: detail.TankMeterUrl ?? "",
                                            operatorDriver: detail.OperatorDriver
                                    );
                                    
                                    _context.GetContext().LogSheetDetails.Add(logSheetDetail);
                                }
                                else {
                                    
                                    existingDetail.AssetCode = detail.AssetCode;
                                    existingDetail.Reading = detail.Reading;
                                    existingDetail.Quantity = detail.Quantity;
                                    existingDetail.OperatorDriver = detail.OperatorDriver;
                                    
                                    _context.GetContext().LogSheetDetails.Update(existingDetail);
                                }
                            }
                        }


                        _context.LogSheets.Update(logSheet);
                        
                    }
                    else
                    {
                        var existingLog = await _context.LogSheets.GetLastLogsheet() ?? new LogSheet();
                        logSheet = new LogSheet
                        {
                            ReferenceNo = existingLog.ReferenceNo + 1,
                            FueledDate = DateTime.Parse(request.SheetRequest.FueledDate),
                            ShiftStartTime = DateTime.Parse(request.SheetRequest.ShiftStartTime),
                            ShiftEndTime = DateTime.Parse(request.SheetRequest.ShiftEndTime),
                            StartShiftTankerKm = request.SheetRequest.StartShiftTankerKm,
                            EndShiftTankerKm = request.SheetRequest.EndShiftTankerKm,
                            StartShiftMeterReading = request.SheetRequest.StartShiftMeterReading,
                            EndShiftMeterReading = request.SheetRequest.EndShiftMeterReading,
                            Location = request.SheetRequest.Location,
                            LVStation = lvStation,
                            CreatedBy = request.SheetRequest.Fueler,
                            CreatedAt = DateTime.Today,
                            UpdatedBy = request.SheetRequest.EmployeeCode,
                            UpdatedAt = DateTime.Today
                        };

                        logSheet.Posted();
                        _context.LogSheets.Add(logSheet);
                    }

                    await _context.SaveChangesAsyncRoot();
                    return Result<LogSheetResponse>.Success(new LogSheetResponse
                    {
                        Id = logSheet!.Id.ToString(),
                        ReferenceNo = logSheet.ReferenceNo
                    });
                }
                catch (Exception ex)
                {
                    return Result<LogSheetResponse>.Failure(ex.Message);
                }

            }
        }
    }
}
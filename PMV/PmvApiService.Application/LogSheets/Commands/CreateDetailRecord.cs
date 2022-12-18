using MediatR;
using Microsoft.EntityFrameworkCore;
using PMV.Application.Interfaces;
using Shared.Core;
using PMV.Application.Common.Exceptions.FuelExceptions;
using PMV.Application.LogSheets.DTO;
using PMV.Core.FuelLogs;

namespace PMV.Application.LogSheets.Commands;

public class CreateDetailRecord
{
    public record Command(LogSheetDetailRequest request) : IRequest<Result<LogSheetDetailResponse>>;

    public class CommandHandler : IRequestHandler<Command, Result<LogSheetDetailResponse>>
    {
        private readonly IUnitWork _context;

        public CommandHandler(IUnitWork context)
        {
            _context = context;

        }

        public bool FieldValidation(Command request)
        {

            if (string.IsNullOrEmpty(request.request.AssetCode))
                throw new Exception("Asset Code must have a value");

            if (request.request.Reading == 0)
                throw new Exception("Reading must have a value");

            if (request.request.Quantity == 0)
                throw new Exception("Quantity must have a value");

            return true;
        }

        public async Task<Result<LogSheetDetailResponse>> Handle(Command request, CancellationToken cancellationToken)
        {

            try
            {

                var isValid = FieldValidation(request);

                //get the logsheet
                LogSheet logsheet = await GetActiveLogSheet(request);

                LogSheetDetail previousRecord = await GetPreviousRecord(request);

                logsheet.AddDetail(LogSheetDetail.Create(
                    assetCode: request.request.AssetCode,
                    fuelTime: DateTime.Parse(request.request.FuelTime),
                    reading: request.request.Reading,
                    previousReading: previousRecord!.Reading,
                    quantity: request.request.Quantity,
                    driverQatarIdUrl: request.request.DriverQatarIdUrl ?? "",
                    currentSMUUrl: request.request.CurrentSMUUrl ?? "",
                    tankMeterUrl: request.request.TankMeterUrl ?? "",
                    operatorDriver: request.request.OperatorDriver
                ));

                _context.LogSheets.Update(logsheet);

                await _context.SaveChangesAsyncRoot();
                var logDetail = logsheet.Details.FirstOrDefault() ?? new LogSheetDetail();
                return Result<LogSheetDetailResponse>.Success(new LogSheetDetailResponse
                {
                    Id = logDetail.Id.ToString(),
                    AssetCode = logDetail.AssetCode,
                    FuelTime = logDetail.FuelTime,
                    Quantity = logDetail.Quantity,
                    OperatorDriver = logDetail.OperatorDriver,
                    Reading = logDetail.Reading,
                    PreviousReading = logDetail.PreviousReading,
                    DriverQatarIdUrl = logDetail.DriverQatarIdUrl
                });

            }
            catch (Exception ex)
            {
                return Result<LogSheetDetailResponse>.Failure(ex.Message);
            }

        }

        private async Task<LogSheetDetail> GetPreviousRecord(Command request)
        {


            //check the previous record
            var previousRecord = await _context.GetContext()
                                    .LogSheetDetails.Where(d => d.AssetCode == request.request.AssetCode)
                                    .OrderByDescending(l => l.LogSheet.CreatedAt)
                                    .FirstOrDefaultAsync() ?? new LogSheetDetail();

            if (request.request.Reading < previousRecord.Reading)
            {
                throw new ReadingException();
            }

            return previousRecord;
        }

        private async Task<LogSheet> GetActiveLogSheet(Command request)
        {
            var logsheet = await _context.LogSheets.GetByIdAsync(Guid.Parse(request.request.LogSheetId));
            if (logsheet == null)
                throw new Exception("Logsheet not Found");

            //check if 
            return logsheet;
        }
    }
}
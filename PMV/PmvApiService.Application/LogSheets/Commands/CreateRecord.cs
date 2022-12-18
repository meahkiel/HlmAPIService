using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;
using PMV.Application.Interfaces;
using PMV.Application.LogSheets.DTO;
using PMV.Core.FuelLogs;
using Shared.Core;

namespace PMV.Application.LogSheets.Commands;

public class CreateRecord
{
    public record Command(LogSheetOpenRequest LogSheetRequest) : IRequest<Result<LogSheetResponse>>;

    public class CommandHandler : IRequestHandler<Command, Result<LogSheetResponse>>
    {
        private readonly IUnitWork _context;
        private readonly IValidator<LogSheetOpenRequest> _validator;

        public CommandHandler(IUnitWork context, IValidator<LogSheetOpenRequest> validator)
        {
            _context = context;
            _validator = validator;
        }

        private bool IsValid(Command request)
        {

            return true;
        }

        public async Task<Result<LogSheetResponse>> Handle(Command request, CancellationToken cancellationToken)
        {
            try
            {

                var result = _validator.Validate(request.LogSheetRequest);

                if (!result.IsValid)
                    throw new Exception("Invalid Data Entry");

                var existingLog = await _context.LogSheets.GetLastLogsheet() ?? new LogSheet();

                var lvStation = await _context.GetContext().LVStations
                                    .SingleOrDefaultAsync(v => v.Code == request.LogSheetRequest.LVStation);

                if (lvStation == null) throw new Exception("Invalid LV Station");

                var logsheet = LogSheet.CreateNewLog(existingLog.ReferenceNo + 1,
                        DateTime.Parse(request.LogSheetRequest.ShiftStartTime),
                        request.LogSheetRequest.StartShiftTankerKm,
                        request.LogSheetRequest.StartShiftMeterReading,
                        request.LogSheetRequest.Location, lvStation);

                _context.LogSheets.Add(logsheet);

                await _context.SaveChangesAsyncRoot(request.LogSheetRequest.EmployeeCode);

                return Result<LogSheetResponse>.Success(new LogSheetResponse
                {
                    Id = logsheet.Id.ToString(),
                    ReferenceNo = logsheet.ReferenceNo,
                    ShiftStartTime = logsheet.ShiftStartTime.ToLongTimeString(),
                    StartShiftMeterReading = logsheet.StartShiftMeterReading,
                    StartShiftTankerKm = logsheet.StartShiftTankerKm,
                    FueledDate = logsheet.FueledDate,
                    Location = logsheet.Location,
                    Remarks = logsheet.Remarks
                });
            }
            catch (Exception ex)
            {

                return Result<LogSheetResponse>.Failure(ex.Message);
            }
            
        }
    }
}
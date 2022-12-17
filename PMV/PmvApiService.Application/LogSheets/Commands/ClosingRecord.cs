using MediatR;
using PMV.PmvApiService.Core.FuelLogs;
using PMV.PmvApiService.Application.Interfaces.Repositories;
using PMV.PmvApiService.Application.Core;
using PMV.PmvApiService.Application.LogSheets.DTO;

namespace PMV.PmvApiService.Application.LogSheets.Commands;

public class ClosingRecord
{
    public record Command(LogSheetCloseRequest LogSheetRequest) : IRequest<Result<Unit>>;

    public class CommandHandler : IRequestHandler<Command, Result<Unit>>
    {
        private readonly IUnitWork _context;

        public CommandHandler(IUnitWork unitWork)
        {
            _context = unitWork;
        }


        public async Task<Result<Unit>> Handle(Command request, CancellationToken cancellationToken)
        {

            try
            {
                LogSheet logsheet = await GetOpenLogSheet(request);

                logsheet.EndShiftMeterReading = request.LogSheetRequest.EndShiftMeterReading;
                logsheet.EndShiftTankerKm = request.LogSheetRequest.EndShiftMeterReading;
                logsheet.ShiftEndTime = DateTime.Parse(request.LogSheetRequest.ShiftEndTime!);
                logsheet.Remarks = request.LogSheetRequest.Remarks;
                logsheet.Posted();

                _context.LogSheets.Update(logsheet);

                await _context.SaveChangesAsyncRoot(request.LogSheetRequest.EmployeeCode);

                return Result<Unit>.Success(Unit.Value);

            }
            catch (Exception ex) {
                return Result<Unit>.Failure(ex.Message);
            }
        }

        private async Task<LogSheet> GetOpenLogSheet(Command request)
        {
            //get the selected logsheet
            var logsheet = await _context.LogSheets
                                    .GetSingleLogSheet(Guid.Parse(request.LogSheetRequest.Id!));

            if (logsheet == null)
                throw new Exception("Log sheet not found");
            
            if(logsheet.Post.IsPosted)
                throw new Exception("Log sheet is posted already");

            return logsheet;
        }
    }
}
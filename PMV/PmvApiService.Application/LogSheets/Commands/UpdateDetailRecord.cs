using MediatR;
using PMV.Application.Interfaces;
using PMV.Application.LogSheets.DTO;
using PMV.Core.FuelLogs;
using Shared.Core;

namespace PMV.Application.LogSheets.Commands;

public class UpdateDetailRecord
{
    public record Command(LogSheetDetailRequest request) : IRequest<Result<LogSheetDetailResponse>>;

    class CommandHandler : IRequestHandler<Command, Result<LogSheetDetailResponse>>
    {
        private readonly IUnitWork _context;

        public CommandHandler(IUnitWork context)
        {
            _context = context;

        }
        public async Task<Result<LogSheetDetailResponse>> Handle(Command request, CancellationToken cancellationToken)
        {

            try
            {

                var logsheet = await _context.LogSheets.GetByIdAsync(Guid.Parse(request.request.LogSheetId));

                if (logsheet == null)
                    throw new Exception("Logsheet not found");

                logsheet.UpdateDetail(
                    request.request.Id!,
                    request.request.AssetCode,
                    request.request.Reading,
                    request.request.Quantity,
                    request.request.OperatorDriver,
                    request.request.DriverQatarIdUrl,
                    request.request.CurrentSMUUrl,
                    request.request.TankMeterUrl);

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
    }
}
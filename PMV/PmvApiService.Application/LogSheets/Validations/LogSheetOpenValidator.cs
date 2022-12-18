using FluentValidation;
using PMV.Application.LogSheets.DTO;

namespace PMV.Application.LogSheets.Validations
{
    public sealed class LogSheetOpenValidator : AbstractValidator<LogSheetOpenRequest>
    {

        public LogSheetOpenValidator()
        {
            RuleFor(c => c.ShiftStartTime).NotNull();
            RuleFor(c => c.ShiftStartTime).Must(IsValidDate);
            RuleFor(c => c.StartShiftMeterReading).GreaterThan(0);

        }


        protected bool IsValidDate(string date)
        {
            return DateTime.TryParse(date, out DateTime newDate);
        }
        
    }
}

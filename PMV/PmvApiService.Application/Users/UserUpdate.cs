using MediatR;
using Microsoft.EntityFrameworkCore;
using PMV.Application.Interfaces;
using Shared.Core;

namespace PMV.Application.Users;

public class UserUpdate
{
    public record Command(string LVStation, string EmployeeCode) : IRequest<Result<Unit>>;

    public class CommandHandler : IRequestHandler<Command, Result<Unit>>
    {
        private readonly IUnitWork _context;

        public CommandHandler(IUnitWork context)
        {
            _context = context;
        }
        public async Task<Result<Unit>> Handle(Command request, CancellationToken cancellationToken)
        {
            try
            {

                var user = await _context.GetContext().Users.SingleOrDefaultAsync(u => u.EmployeeCode == request.EmployeeCode);

                if (user == null)
                    throw new Exception("User not found");

                user.Section = request.LVStation;

                _context.GetContext().Users.Update(user);

                await _context.SaveChangesAsyncRoot();

                return Result<Unit>.Success(Unit.Value);

            }
            catch (Exception ex)
            {
                return Result<Unit>.Failure(ex.Message);
            }

        }
    }
}
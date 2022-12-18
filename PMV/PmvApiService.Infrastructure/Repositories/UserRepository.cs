using Microsoft.EntityFrameworkCore;
using PMV.Core.User;
using PMV.Persistence.Context;

namespace PMV.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly PMVDataContext _context;

        public UserRepository(PMVDataContext context)
        {
            _context = context;
        }


        public async Task<PMVUser?> GetUserProfile(string employeeCode)
        {
            return await _context.Users.SingleOrDefaultAsync(u => u.EmployeeCode == employeeCode);
        }
    }
}
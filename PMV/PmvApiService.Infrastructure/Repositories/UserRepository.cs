using Microsoft.EntityFrameworkCore;
using PMV.PmvApiService.Core.User;
using PMV.PmvApiService.Persistence.Context;

namespace PMV.PmvApiService.Infrastructure.Repositories
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
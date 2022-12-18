using Microsoft.EntityFrameworkCore;
using PMV.Application.Interfaces;
using PMV.Core.BaseEntity;
using PMV.Core.FuelLogs;
using PMV.Core.User;
using PMV.Persistence.Context;

namespace PMV.Infrastructure.Repositories
{
    public class UnitWork : IUnitWork
    {

        private PMVDataContext _context;

        private IUserRepository _users;

        private ILogSheetRepository _logsheet;

        public UnitWork(PMVDataContext context)
        {
            _context = context;
        }


        public ILogSheetRepository LogSheets
        {
            get
            {
                if (_logsheet == null)
                    _logsheet = new LogsheetRepository(_context);
                return _logsheet;
            }
        }

        public IUserRepository Users
        {
            get
            {
                if (_users == null)
                    _users = new UserRepository(_context);
                return _users;
            }
        }

        public PMVDataContext GetContext()
        {
            return _context;
        }

        public async Task SaveChangesAsyncRoot(string userOrgId)
        {


            foreach (var entry in _context.ChangeTracker.Entries().Where(e => e.State == EntityState.Added ||
                e.State == EntityState.Modified))
            {

                if (entry.Entity.GetType().GetCustomAttributes(typeof(AuditableAttribute), true).Length > 0)
                {
                    if (entry.State == EntityState.Added)
                    {
                        if (entry.Property("CreatedAt") != null)
                        {
                            entry.Property("CreatedBy").CurrentValue = userOrgId;
                            entry.Property("CreatedAt").CurrentValue = DateTime.Now;
                        }
                    }
                    else if (entry.State == EntityState.Modified)
                    {
                        if (entry.Property("UpdatedAt") != null)
                        {
                            entry.Property("UpdatedBy").CurrentValue = userOrgId;
                            entry.Property("UpdatedAt").CurrentValue = DateTime.Now;
                        }
                    }
                }
            }

            await SaveChangesAsyncRoot();
        }

        public async Task SaveChangesAsyncRoot()
        {
            await _context.SaveChangesAsync();
        }
    }
}
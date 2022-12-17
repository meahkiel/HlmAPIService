using Microsoft.EntityFrameworkCore;
using PMV.PmvApiService.Core.FuelLogs;
using PMV.PmvApiService.Persistence.Context;
using PmvApiService.Core.FuelLogs;

namespace PMV.PmvApiService.Infrastructure.Repositories
{
    public class LogsheetRepository : ILogSheetRepository
    {
        private readonly PMVDataContext _context;

        public LogsheetRepository(PMVDataContext context)
        {
            _context = context;
        }
        public void Add(LogSheet value)
        {
            _context.LogSheets.Add(value);
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task<IEnumerable<LogSheet>> GetAll()
        {
            return await _context.LogSheets.ToListAsync();
        }

        public async Task<LogSheet?> GetByIdAsync(Guid Id)
        {
            return await _context.LogSheets
                            .Include(l => l.Details)
                            .Include(l => l.LVStation)
                            .FirstOrDefaultAsync(l => l.Id == Id);
        }



        public async Task<IEnumerable<LogSheet>> GetByLVStation(string lvStation,bool isPosted = false)
        {
            return await _context.LogSheets
                            .Include(l => l.Details)
                            .Include(l => l.LVStation)
                            .Where(l => l.LVStation.Code == lvStation && l.Post.IsPosted == isPosted)
                            .ToListAsync();
        }

        public async Task<LogSheet?> GetLastLogsheet()
        {
            return await _context.LogSheets
                    .OrderBy(l => l.CreatedAt)
                    .OrderBy(l => l.ReferenceNo)
                    .LastOrDefaultAsync();
        }

        public async Task<LogSheet?> GetSingleLogSheet(Guid id)
        {
           return await _context.LogSheets.FindAsync(id);
        }

        public void Update(LogSheet value)
        {
            _context.LogSheets.Update(value);
        }
    }
}
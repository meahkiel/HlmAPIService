using PMV.Core.Interfaces;

namespace PMV.Core.FuelLogs
{
    public interface ILogSheetRepository : IRepository<LogSheet>
    {

        Task<LogSheet?> GetSingleLogSheet(Guid id);
        Task<IEnumerable<LogSheet>> GetByLVStation(string lvStation, bool isPosted = false);


        Task<LogSheet?> GetLastLogsheet();
    }
}
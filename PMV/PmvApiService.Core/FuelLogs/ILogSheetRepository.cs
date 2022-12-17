using PMV.PmvApiService.Core.FuelLogs;
using PMV.PmvApiService.Core.Interfaces;

namespace PmvApiService.Core.FuelLogs
{
    public interface ILogSheetRepository : IRepository<LogSheet>
    {

        Task<LogSheet?> GetSingleLogSheet(Guid id);
        Task<IEnumerable<LogSheet>> GetByLVStation(string lvStation, bool isPosted = false);


        Task<LogSheet?> GetLastLogsheet();
    }
}
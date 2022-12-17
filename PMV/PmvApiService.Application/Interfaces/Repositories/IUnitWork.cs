using PmvApiService.Core.FuelLogs;
using PMV.PmvApiService.Core.User;
using PMV.PmvApiService.Persistence.Context;

namespace PMV.PmvApiService.Application.Interfaces.Repositories
{
    public interface IUnitWork
    {
        
        public IUserRepository Users { get; }

        public ILogSheetRepository LogSheets {get;}

        PMVDataContext GetContext();

        Task SaveChangesAsyncRoot();
        Task SaveChangesAsyncRoot(string userOrgId);


    }
}
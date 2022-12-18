using PMV.Persistence.Context;
using PMV.Core.FuelLogs;
using PMV.Core.User;

namespace PMV.Application.Interfaces;

public interface IUnitWork
{

    public IUserRepository Users { get; }

    public ILogSheetRepository LogSheets { get; }

    PMVDataContext GetContext();

    Task SaveChangesAsyncRoot();
    Task SaveChangesAsyncRoot(string userOrgId);


}
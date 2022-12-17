using ExportReports.DTO;

namespace ExportReports.Applications;

public interface IDataService
{
    
    Task<IEnumerable<ItemMasterResult>> GetData(
        string? company = null,
        string? projectDepartment = null,
        string? itemGroups = null,
        string? itemSubGroups = null,
        string? itemCategory = null,
        string? itemSubCategory = null,
        string? dateFrom = null,
        string? dateTo = null); 
    
}

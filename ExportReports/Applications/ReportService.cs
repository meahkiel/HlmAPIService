using ExportReports.DTO;
using ExportReports.Infrastructure;

namespace ExportReports.Applications
{
    public class ReportService
    {

         private readonly IDataService _dataService;

        public ReportService(IDataService dataService)
        {
            _dataService = dataService;
        }
        public async Task<byte[]> ExportItem(FilterRequest request) {

            IEnumerable<ItemMasterResult> data = await _dataService.GetData(
                request.Company,
                request.ProjDept,
                request.ItemGroups,
                request.ItemSubGroups,
                request.ItemCategory,
                request.ItemSubCategory,
                request.DateFrom,
                request.DateTo);

            var fileContent = await ExcelExportHelper.ExportExcel(data.ToList());
            return fileContent;
        }
    }
}
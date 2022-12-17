using ExportReports.Applications;
using ExportReports.DTO;
using ExportReports.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/reports/[controller]")]
    public class ExportController : ControllerBase
    {
        private readonly ReportService _reportService;
        
        public ExportController(ReportService reportService)
        {
            _reportService = reportService;
        }

        [HttpGet("item")]
        public async Task<IActionResult> Item([FromQuery]FilterRequest request) {

            return File(await _reportService.ExportItem(request), ExcelExportHelper.ExcelContentType,"ItemExport.xlsx");
        }
    }
}
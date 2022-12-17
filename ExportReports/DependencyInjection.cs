using ExportReports.Applications;
using ExportReports.Infrastructure.DataService;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ExportReports;

public static class DependencyInjection
{
    public static IServiceCollection AddExportApplication(this IServiceCollection services,IConfiguration configuration) {
        
        services.AddScoped<IDataService, ItemReportService>(opt => new ItemReportService(configuration.GetConnectionString("PortalDb")));
        services.AddScoped<ReportService>();
        return services;
    }
}

using System.Reflection;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PMV.PmvApiService.Application.LogSheets.Commands;
using PMV.PmvApiService.Persistence.Context;

namespace PMV.PmvApiService.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddPMVApplication(this IServiceCollection service, IConfiguration configuration,string environment) {
        
        service.AddDbContext<PMVDataContext>(opt => opt.UseSqlServer(configuration.GetConnectionString(environment)));
        service.AddMediatR(Assembly.GetExecutingAssembly(),typeof(CreateRecord).Assembly);
        return service;
    }
}
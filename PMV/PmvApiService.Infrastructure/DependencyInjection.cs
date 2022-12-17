using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PMV.PmvApiService.Application.Interfaces;
using PMV.PmvApiService.Application.Interfaces.Authentications;
using PMV.PmvApiService.Application.Interfaces.Repositories;
using PMV.PmvApiService.Infrastructure.Core;
using PMV.PmvApiService.Infrastructure.Repositories;
using PMV.PmvApiService.Infrastructure.Services;
using PMV.PMVApiService.SupportContext.Connections;
using PMV.PMVApiService.SupportContext.Query;

namespace PMV.PmvApiService.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddPMVInfrastructure(this IServiceCollection service,IConfiguration configuration) {

        service.Configure<ResourceSetting>(configuration.GetSection("ResourceSetting"));
        
        service.AddScoped<IUnitWork,UnitWork>();
        service.AddScoped<IImageAccessor,ImageAccessor>();
        service.AddScoped<IAuthService,AuthService>();

        service.AddScoped<SupportDataConnection>(opt => new SupportDataConnection(configuration.GetConnectionString("PortalDb") ?? ""));
        service.AddScoped<UserAuthCommand>();
        
        
        return service;
    }
}
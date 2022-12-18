using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PMV.Application.Interfaces;
using PMV.Infrastructure.Core;
using PMV.Infrastructure.Repositories;
using PMV.Infrastructure.Services;
using PMV.SupportContext.Connections;
using PMV.SupportContext.Query;

namespace PMV.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddPMVInfrastructure(this IServiceCollection service, IConfiguration configuration)
    {

        service.Configure<ResourceSetting>(configuration.GetSection("ResourceSetting"));

        service.AddScoped<IUnitWork, UnitWork>();
        service.AddScoped<IImageAccessor, ImageAccessor>();
        service.AddScoped<IAuthService, AuthService>();

        service.AddScoped(opt => new SupportDataConnection(configuration.GetConnectionString("PortalDb") ?? ""));
        service.AddScoped<UserAuthCommand>();


        return service;
    }
}
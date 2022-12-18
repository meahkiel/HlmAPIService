using System.Reflection;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PMV.Application.LogSheets.Commands;
using PMV.Application.LogSheets.Validations;
using PMV.Persistence.Context;




namespace PMV.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddPMVApplication(this IServiceCollection service, IConfiguration configuration, string environment)
    {

        service.AddDbContext<PMVDataContext>(opt => opt.UseSqlServer(configuration.GetConnectionString(environment)));
        service.AddMediatR(Assembly.GetExecutingAssembly(), typeof(CreateRecord).Assembly);
        service.AddValidatorsFromAssemblyContaining<LogSheetOpenValidator>();
        return service;
    }
}
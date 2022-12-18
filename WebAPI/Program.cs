
using ExportReports;
using PMV.Application;
using PMV.Infrastructure;
using WebAPI.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddExportApplication(builder.Configuration);
builder.Services.AddPMVApplication(builder.Configuration, "PortalServiceDb")
            .AddPMVInfrastructure(builder.Configuration);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//allow any request host to use API provided with Auth Bearer
builder.Services.AddCors(opt =>
{
    opt.AddPolicy("AllCors", builder =>
    {
        builder.AllowAnyOrigin();
        builder.AllowAnyHeader();
        builder.AllowAnyMethod();
    });
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();
//app.UseAuthorization();

app.UseMiddleware<ErrorExceptionMiddleware>();
app.UseCors("AllCors");
app.MapControllers();

app.Run();

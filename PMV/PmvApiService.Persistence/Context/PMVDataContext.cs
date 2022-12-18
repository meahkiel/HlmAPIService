
using Microsoft.EntityFrameworkCore;
using PMV.Core.Common.Locations;
using PMV.Core.FuelLogs;
using PMV.Core.FuelStations;
using PMV.Core.User;

namespace PMV.Persistence.Context;

public class PMVDataContext : DbContext
{

    public DbSet<ProjectLocation> ProjectLocations { get; set; }
    public DbSet<LVStation> LVStations { get; set; }
    public DbSet<PMVUser> Users { get; set; }

    public DbSet<LogSheet> LogSheets { get; set; }
    public DbSet<LogSheetDetail> LogSheetDetails { get; set; }


    public PMVDataContext(DbContextOptions<PMVDataContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.HasDefaultSchema("PMV");
        modelBuilder.ApplyConfiguration(new LogSheetConfig());
        modelBuilder.ApplyConfiguration(new LogSheetDetailConfig());
        modelBuilder.ApplyConfiguration(new ProjectLocationConfig());


        modelBuilder.Entity<PMVUser>()
            .HasAlternateKey(p => p.EmployeeCode);
        modelBuilder.Entity<PMVUser>()
            .HasData(new PMVUser { EmployeeCode = "H22095411", EmailAddress = "amercado@helm.qa", FullName = "Arnold Mercado", Department = "PMV", Section = "LV253" });








    }

    private void SeedData(ModelBuilder modelBuilder)
    {




    }

}
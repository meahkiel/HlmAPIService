
using Microsoft.EntityFrameworkCore;
using PMV.PmvApiService.Core.FuelLogs;
using PMV.PmvApiService.Core.Locations;
using PMV.PmvApiService.Core.LVStations;
using PMV.PmvApiService.Core.User;

namespace PMV.PmvApiService.Persistence.Context
{
    public class PMVDataContext : DbContext
    {
        
        public DbSet<ProjectLocation> ProjectLocations { get; set; }
        public DbSet<LVStation> LVStations { get; set; }
        public DbSet<PMVUser> Users { get; set; }

        public DbSet<LogSheet> LogSheets { get; set; }
        public DbSet<LogSheetDetail> LogSheetDetails { get; set; }


        public PMVDataContext(DbContextOptions<PMVDataContext> options)
            : base(options) {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.HasDefaultSchema("PMV");

            modelBuilder.Entity<LogSheet>().HasKey(e => e.Id);
            modelBuilder.Entity<LogSheet>().OwnsOne(l => l.Post);

            modelBuilder.Entity<LogSheetDetail>()
                .HasOne(d => d.LogSheet)
                .WithMany(s => s.Details);

            

            modelBuilder.Entity<PMVUser>()
                .HasAlternateKey(p => p.EmployeeCode);
            modelBuilder.Entity<PMVUser>()
                .HasData(new PMVUser { EmployeeCode = "H22095411", EmailAddress="amercado@helm.qa", FullName = "Arnold Mercado", Department="PMV", Section="LV253" });

            modelBuilder.Entity<ProjectLocation>()
               .HasKey(e => e.Id);

            modelBuilder.Entity<ProjectLocation>()
               .HasAlternateKey(p => p.DepartmentName);

            
            modelBuilder.Entity<LVStation>()
               .HasKey(e => e.Id);

            modelBuilder.Entity<LVStation>()
               .HasAlternateKey(e => e.Code);

            SeedData(modelBuilder);
            
        }

        private void SeedData(ModelBuilder modelBuilder) {

            modelBuilder.Entity<ProjectLocation>().HasData(
                new ProjectLocation {DepartmentName = "D191"},
                new ProjectLocation {DepartmentName = "D192"},
                new ProjectLocation {DepartmentName = "D182"},
                new ProjectLocation {DepartmentName = "D172"},
                new ProjectLocation {DepartmentName = "D171"},
                new ProjectLocation {DepartmentName = "D183"},
                new ProjectLocation {DepartmentName = "I201"},
                new ProjectLocation {DepartmentName = "FULLBORE D191"},
                new ProjectLocation {DepartmentName = "FULLBORE D192"},
                new ProjectLocation {DepartmentName = "FULLBORE D182"},
                new ProjectLocation {DepartmentName = "FULLBORE OTHERS"},
                new ProjectLocation {DepartmentName = "POLARIS D172"},
                new ProjectLocation {DepartmentName = "UEG D191"},
                new ProjectLocation {DepartmentName = "UEG D192"},
                new ProjectLocation {DepartmentName = "UEG D182"},
                new ProjectLocation {DepartmentName = "TOPROK MAZRUA"},
                new ProjectLocation {DepartmentName = "TOPROK WUKAIR"},
                new ProjectLocation {DepartmentName = "TOPROK SHAHANIYA"},
                new ProjectLocation {DepartmentName = "TOPROK OTHERS"},
                new ProjectLocation {DepartmentName = "QONCRETE WUKAIR"},
                new ProjectLocation {DepartmentName = "QONCRETE MAZRUA"},
                new ProjectLocation {DepartmentName = "QAP PLANT"},
                new ProjectLocation {DepartmentName = "ASPHALT CREW"},
                new ProjectLocation {DepartmentName = "PMV"},
                new ProjectLocation {DepartmentName = "BRU"},
                new ProjectLocation {DepartmentName = "TRANSPORT"},
                new ProjectLocation {DepartmentName = "LOGISTICS"},
                new ProjectLocation {DepartmentName = "JERRY CAN/ PROJECT/DEPT."},
                new ProjectLocation {DepartmentName = "GAP Plant"},
                new ProjectLocation {DepartmentName = "I211"},
                new ProjectLocation {DepartmentName = "LUSAIL"},
                new ProjectLocation {DepartmentName = "AL THAKIRA"},
                new ProjectLocation {DepartmentName = "TOPROK I211"},
                new ProjectLocation {DepartmentName = "D211"},
                new ProjectLocation {DepartmentName = "I203"},
                new ProjectLocation {DepartmentName = "Helm Holding W.L.L"},
                new ProjectLocation {DepartmentName = "I216"},
                new ProjectLocation {DepartmentName = "I214"},
                new ProjectLocation {DepartmentName = "I212"},
                new ProjectLocation {DepartmentName = "I215"},
                new ProjectLocation {DepartmentName = "Precast D192"},
                new ProjectLocation {DepartmentName = "I222"},
                new ProjectLocation {DepartmentName = "I224"},
                new ProjectLocation {DepartmentName = "D211-Wakra"},
                new ProjectLocation {DepartmentName = "I227_Fullbore"}
            );

            modelBuilder.Entity<LVStation>().HasData(
                new LVStation { Code = "LV375", FuelStation = "LV375" },
                new LVStation { Code = "LV253", FuelStation = "LV253" },
                new LVStation { Code = "LV215", FuelStation = "LV215" },
                new LVStation { Code = "LLV463", FuelStation = "LLV463" },
                new LVStation { Code = "LLV478", FuelStation = "LLV478" },
                new LVStation { Code = "LV310", FuelStation = "LV310" },
                new LVStation { Code = "LV512", FuelStation = "LV512" },
                new LVStation { Code = "D182Station", FuelStation = "D182Station" },
                new LVStation { Code = "D192Station", FuelStation = "D192Station" },
                new LVStation { Code = "QAPMSDStation", FuelStation = "QAPMSDStation" }
            );

        }

    }
}
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PMV.Core.Common.Locations;

namespace PMV.Persistence.Context
{
    public class ProjectLocationConfig : IEntityTypeConfiguration<ProjectLocation>
    {
        public void Configure(EntityTypeBuilder<ProjectLocation> builder)
        {

            builder.HasKey(e => e.Id);
            builder.HasAlternateKey(p => p.DepartmentName);

            builder.HasData(
              new ProjectLocation { DepartmentName = "D191" },
              new ProjectLocation { DepartmentName = "D192" },
              new ProjectLocation { DepartmentName = "D182" },
              new ProjectLocation { DepartmentName = "D172" },
              new ProjectLocation { DepartmentName = "D171" },
              new ProjectLocation { DepartmentName = "D183" },
              new ProjectLocation { DepartmentName = "I201" },
              new ProjectLocation { DepartmentName = "FULLBORE D191" },
              new ProjectLocation { DepartmentName = "FULLBORE D192" },
              new ProjectLocation { DepartmentName = "FULLBORE D182" },
              new ProjectLocation { DepartmentName = "FULLBORE OTHERS" },
              new ProjectLocation { DepartmentName = "POLARIS D172" },
              new ProjectLocation { DepartmentName = "UEG D191" },
              new ProjectLocation { DepartmentName = "UEG D192" },
              new ProjectLocation { DepartmentName = "UEG D182" },
              new ProjectLocation { DepartmentName = "TOPROK MAZRUA" },
              new ProjectLocation { DepartmentName = "TOPROK WUKAIR" },
              new ProjectLocation { DepartmentName = "TOPROK SHAHANIYA" },
              new ProjectLocation { DepartmentName = "TOPROK OTHERS" },
              new ProjectLocation { DepartmentName = "QONCRETE WUKAIR" },
              new ProjectLocation { DepartmentName = "QONCRETE MAZRUA" },
              new ProjectLocation { DepartmentName = "QAP PLANT" },
              new ProjectLocation { DepartmentName = "ASPHALT CREW" },
              new ProjectLocation { DepartmentName = "PMV" },
              new ProjectLocation { DepartmentName = "BRU" },
              new ProjectLocation { DepartmentName = "TRANSPORT" },
              new ProjectLocation { DepartmentName = "LOGISTICS" },
              new ProjectLocation { DepartmentName = "JERRY CAN/ PROJECT/DEPT." },
              new ProjectLocation { DepartmentName = "GAP Plant" },
              new ProjectLocation { DepartmentName = "I211" },
              new ProjectLocation { DepartmentName = "LUSAIL" },
              new ProjectLocation { DepartmentName = "AL THAKIRA" },
              new ProjectLocation { DepartmentName = "TOPROK I211" },
              new ProjectLocation { DepartmentName = "D211" },
              new ProjectLocation { DepartmentName = "I203" },
              new ProjectLocation { DepartmentName = "Helm Holding W.L.L" },
              new ProjectLocation { DepartmentName = "I216" },
              new ProjectLocation { DepartmentName = "I214" },
              new ProjectLocation { DepartmentName = "I212" },
              new ProjectLocation { DepartmentName = "I215" },
              new ProjectLocation { DepartmentName = "Precast D192" },
              new ProjectLocation { DepartmentName = "I222" },
              new ProjectLocation { DepartmentName = "I224" },
              new ProjectLocation { DepartmentName = "D211-Wakra" },
              new ProjectLocation { DepartmentName = "I227_Fullbore" }
          );

        }
    }
}

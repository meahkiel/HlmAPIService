using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PMV.Core.FuelStations;

namespace PMV.Persistence.Context;

public class StationConfig : IEntityTypeConfiguration<LVStation>
{
    public void Configure(EntityTypeBuilder<LVStation> builder)
    {
        builder.HasKey(e => e.Id);
        builder.HasAlternateKey(e => e.Code);

        builder.HasData(
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

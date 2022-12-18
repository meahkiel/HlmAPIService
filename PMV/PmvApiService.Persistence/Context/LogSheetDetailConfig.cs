using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PMV.Core.FuelLogs;

namespace PMV.Persistence.Context;

public class LogSheetDetailConfig : IEntityTypeConfiguration<LogSheetDetail>
{


    public void Configure(EntityTypeBuilder<LogSheetDetail> builder)
    {
        builder
          .HasOne(d => d.LogSheet)
          .WithMany(s => s.Details);
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PMV.Core.FuelLogs;

namespace PMV.Persistence.Context;

public class LogSheetConfig : IEntityTypeConfiguration<LogSheet>
{
    public void Configure(EntityTypeBuilder<LogSheet> builder)
    {
        builder.HasKey(e => e.Id);
        builder.OwnsOne(l => l.Post);

    }
}

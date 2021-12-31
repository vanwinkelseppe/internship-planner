using Internship.Planner.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Internship.Planner.Infrastructure.EntityFramework.Config;

public class LectorConfig : IEntityTypeConfiguration<Lector>
{
    public void Configure(EntityTypeBuilder<Lector> builder)
    {
        var table = builder.ToTable("Lector");
        table.HasKey("Id");
    }
}
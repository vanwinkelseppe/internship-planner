using Internship.Planner.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Internship.Planner.Infrastructure.EntityFramework.Config;

public class LocationConfig : IEntityTypeConfiguration<Location>
{
    public void Configure(EntityTypeBuilder<Location> builder)
    {
        var table = builder.ToTable("Location");
        table.HasKey("Id");
        table.HasMany(_ => _.Departments).WithOne(_ => _.Location);
    }
}
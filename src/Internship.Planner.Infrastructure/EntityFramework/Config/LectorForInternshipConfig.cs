using Internship.Planner.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Internship.Planner.Infrastructure.EntityFramework.Config;

public class LectorForInternshipConfig : IEntityTypeConfiguration<LectorForInternship>
{
    public void Configure(EntityTypeBuilder<LectorForInternship> builder)
    {
        var table = builder.ToTable("LectorForInternship");
        table.HasKey("Id");
        table.HasOne(_ => _.Internship).WithMany(_ => _.LectorForInternships);
        table.HasOne(_ => _.Lector);
    }
}
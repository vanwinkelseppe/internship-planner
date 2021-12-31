using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Internship.Planner.Infrastructure.EntityFramework.Config;

public class InternshipConfig : IEntityTypeConfiguration<Domain.Internship>
{
    public void Configure(EntityTypeBuilder<Domain.Internship> builder)
    {
        var table = builder.ToTable("Internship");
        table.HasKey("Id");
    }
}
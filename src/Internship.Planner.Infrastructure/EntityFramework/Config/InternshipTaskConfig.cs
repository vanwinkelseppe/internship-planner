using Internship.Planner.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Internship.Planner.Infrastructure.EntityFramework.Config;

public class InternshipTaskConfig : IEntityTypeConfiguration<InternshipTask>
{
    public void Configure(EntityTypeBuilder<InternshipTask> builder)
    {
        var table = builder.ToTable("InternshipTask");
        table.HasKey("Id");
    }
}
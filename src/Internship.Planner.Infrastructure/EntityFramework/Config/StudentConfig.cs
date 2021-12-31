using Internship.Planner.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Internship.Planner.Infrastructure.EntityFramework.Config;

public class StudentConfig : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        var table = builder.ToTable("Student");
        table.HasKey("Id");
    }
}
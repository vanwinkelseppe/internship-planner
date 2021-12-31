using Internship.Planner.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Internship.Planner.Infrastructure.EntityFramework.Config;

public class DepartmentContactConfig : IEntityTypeConfiguration<DepartmentContact>
{
    public void Configure(EntityTypeBuilder<DepartmentContact> builder)
    {
        var table = builder.ToTable("DepartmentContact");
        table.HasKey("Id");
    }
}
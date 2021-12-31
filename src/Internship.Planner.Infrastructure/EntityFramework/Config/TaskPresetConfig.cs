using Internship.Planner.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Internship.Planner.Infrastructure.EntityFramework.Config;

public class TaskPresetConfig : IEntityTypeConfiguration<TaskPreset>
{
    public void Configure(EntityTypeBuilder<TaskPreset> builder)
    {
        var table = builder.ToTable("TaskPreset");
        table.HasKey("Id");
    }
}
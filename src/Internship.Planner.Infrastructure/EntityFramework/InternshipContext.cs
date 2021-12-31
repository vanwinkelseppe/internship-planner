using Internship.Planner.Domain;
using Microsoft.EntityFrameworkCore;

namespace Internship.Planner.Infrastructure.EntityFramework;

public class InternshipContext : DbContext, IInternshipContext
{
    public InternshipContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        var entityTypeConfigurationRegistration = new EntityTypeConfigurationRegistration(modelBuilder);
        entityTypeConfigurationRegistration.Register(GetType().Assembly);
    }

    public DbSet<Lector> Lectors { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<InternshipTask> InternshipTasks { get; set; }
    public DbSet<Domain.Internship> Internships { get; set; }
    public DbSet<Location> Locations { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<DepartmentContact> DepartmentContacts { get; set; }
    public DbSet<TaskPreset> TaskPresets { get; set; }
    public DbSet<LectorForInternship> LectorForInternships { get; set; }
}
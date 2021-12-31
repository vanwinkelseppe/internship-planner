using Internship.Planner.Domain;
using Microsoft.EntityFrameworkCore;

namespace Internship.Planner.Infrastructure.EntityFramework;

public interface IInternshipContext
{
    DbSet<Lector> Lectors { get; }
    DbSet<Student> Students { get; }
    DbSet<InternshipTask> InternshipTasks { get; }
    DbSet<Domain.Internship> Internships { get; }
    DbSet<Location> Locations { get; }
    DbSet<Department> Departments { get; }
    DbSet<DepartmentContact> DepartmentContacts { get; }
    DbSet<TaskPreset> TaskPresets { get; }
    DbSet<LectorForInternship> LectorForInternships { get; }
    Task<int> SaveChangesAsync(CancellationToken token);
}
namespace Internship.Planner.Domain;

public class Internship
{
    public Internship(Guid studentId, DateTime startDate, DateTime endDate)
    {
        StudentId = studentId;
        StartDate = startDate;
        EndDate = endDate;
    }

    private Internship()
    {
    }

    public Guid Id { get; private set; }
    public Guid StudentId { get; }
    public virtual Student Student { get; private set; }
    public DateTime StartDate { get; }
    public DateTime EndDate { get; }

    public virtual ICollection<LectorForInternship> LectorForInternships { get; private set; }
}
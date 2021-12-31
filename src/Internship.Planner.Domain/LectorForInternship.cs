namespace Internship.Planner.Domain;

public class LectorForInternship
{
    public Guid LectorId { get; private set; }
    public virtual Lector Lector { get; private set; }

    public Guid InternshipId { get; private set; }
    public virtual Internship Internship { get; private set; }
}
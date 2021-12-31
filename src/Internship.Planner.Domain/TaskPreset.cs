namespace Internship.Planner.Domain;

public class TaskPreset
{
    public TaskPreset(string name, Guid lectorId)
    {
        Name = name;
        LectorId = lectorId;
    }

    public TaskPreset()
    {
    }

    public Guid Id { get; private set; }
    public string Name { get; }
    public Guid LectorId { get; }
    public virtual Lector Type { get; private set; }
}
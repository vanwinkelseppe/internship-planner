namespace Internship.Planner.Domain;

public class InternshipTask
{
    public InternshipTask(Guid? internshipId, Guid? taskPresetId, DateTime date, bool done, string text, string title)
    {
        InternshipId = internshipId;
        TaskPresetId = taskPresetId;
        Date = date;
        Done = done;
        Text = text;
        Title = title;
    }

    public Guid Id { get; private set; }
    public Guid? InternshipId { get; }
    public virtual Internship Internship { get; private set; }
    public Guid? TaskPresetId { get; }
    public virtual TaskPreset TaskPreset { get; private set; }
    public DateTime Date { get; }
    public bool Done { get; }
    public string Text { get; }
    public string Title { get; }
}
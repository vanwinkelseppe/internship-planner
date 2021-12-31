namespace Internship.Planner.Domain;

public class Department
{
    public Department(Guid locationId, string name, string code)
    {
        LocationId = locationId;
        Name = name;
        Code = code;
    }

    private Department()
    {
        //EF Initializer
    }

    public Guid Id { get; private set; }
    public Guid LocationId { get; private set; }
    public virtual Location Location { get; private set; }
    public string Name { get; private set; }
    public string Code { get; private set; }
    
    public virtual ICollection<DepartmentContact> Contacts { get; private set; }

    public void UpdateName(string name)
    {
        if (name.Length > 512 || string.IsNullOrWhiteSpace(name))
            throw new InvalidDataException(); //Refactor to custom exception
        Name = name;
    }

    public void UpdateLocation(Guid locationId)
    {
        LocationId = locationId;
    }

    public void UpdateCode(string code)
    {
        if (code.Length > 60 || string.IsNullOrWhiteSpace(code))
            throw new InvalidDataException(); //Refactor to custom exception
        Code = code;
    }
}
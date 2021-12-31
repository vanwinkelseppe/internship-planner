namespace Internship.Planner.Domain;

public class Location
{
    public Location(string name, string address)
    {
        Name = name;
        Address = address;
    }

    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public string Address { get; private set; }

    public virtual ICollection<Department> Departments { get; private set; }

    public void UpdateName(string name)
    {
        if (name.Length > 256 || string.IsNullOrWhiteSpace(name))
            throw new InvalidDataException(); //Refactor to custom exception
        Name = name;
    }

    public void UpdateAddress(string address)
    {
        if (address.Length > 1024 || string.IsNullOrWhiteSpace(address))
            throw new InvalidDataException(); //Refactor to custom exception
        Address = address;
    }
}
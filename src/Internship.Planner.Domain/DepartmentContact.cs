namespace Internship.Planner.Domain;

public class DepartmentContact
{
    public DepartmentContact(Guid departmentId, string name, string surname, string email, string phoneNumber)
    {
        DepartmentId = departmentId;
        Name = name;
        Surname = surname;
        Email = email;
        PhoneNumber = phoneNumber;
    }

    public Guid Id { get; private set; }
    public Guid DepartmentId { get; private set; }
    public virtual Department Department { get; private set; }
    public string Name { get; private set; }
    public string Surname { get; private set; }
    public string Email { get; private set; }
    public string PhoneNumber { get; private set; }

    public void UpdateName(string name, string surname)
    {
        if (name.Length > 256 || string.IsNullOrWhiteSpace(name))
            throw new InvalidDataException(); //Refactor to custom exception
        Name = name;

        if (surname.Length > 256 || string.IsNullOrWhiteSpace(surname))
            throw new InvalidDataException(); //Refactor to custom exception
        Surname = surname;
    }

    public void UpdateEmail(string email)
    {
        if (email.Length > 512)
            throw new InvalidDataException(); //Refactor to custom exception
        Email = email;
    }

    public void UpdatePhoneNumber(string phoneNumber)
    {
        if (phoneNumber.Length > 60)
            throw new InvalidDataException(); //Refactor to custom exception
        PhoneNumber = phoneNumber;
    }

    public void UpdateDepartment(Guid departmentId)
    {
        DepartmentId = departmentId;
    }
}
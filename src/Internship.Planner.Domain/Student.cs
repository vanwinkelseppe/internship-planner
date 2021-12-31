namespace Internship.Planner.Domain;

public class Student
{
    public Student(string name, string surname, string email, string phoneNumber)
    {
        Name = name;
        Surname = surname;
        Email = email;
        PhoneNumber = phoneNumber;
    }

    public Guid Id { get; private set; }
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
}
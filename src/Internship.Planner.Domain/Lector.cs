namespace Internship.Planner.Domain;

public class Lector
{
    public Lector(string code, string name, string surname, string email, string phoneNumber)
    {
        Code = code;
        Name = name;
        Surname = surname;
        Email = email;
        PhoneNumber = phoneNumber;
    }

    private Lector()
    {
    }

    public Guid Id { get; private set; }
    public string Code { get; }
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
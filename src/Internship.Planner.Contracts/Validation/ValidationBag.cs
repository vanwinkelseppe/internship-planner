namespace Internship.Planner.Contracts.Validation;

public class ValidationBag
{
    public ValidationBag(IEnumerable<Error> errors)
    {
        Errors = errors;
    }

    public IEnumerable<Error> Errors { get; }
    public bool IsValid => !Errors.Any();
}
using Internship.Planner.Enums;

namespace Internship.Planner.Service.Validation;

public class ValidationBag
{
    private readonly List<Error> _errors;

    private readonly ValidationErrorCode[] _notFoundErrors =
    {
    };

    public ValidationBag()
    {
        _errors = new List<Error>();
    }

    public IEnumerable<Error> Errors => _errors.AsEnumerable();

    public bool IsValid => !_errors.Any();
    public bool HasNotFoundError => _errors.Any(x => _notFoundErrors.Contains(x.ValidationErrorCode));

    public void AddError(ValidationErrorCode error)
    {
        _errors.Add(new Error(error));
    }

    public void AddError(ValidationErrorCode error, object parameters)
    {
        _errors.Add(new Error(error, parameters));
    }
}
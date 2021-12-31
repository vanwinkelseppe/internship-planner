using Internship.Planner.Enums;

namespace Internship.Planner.Service.Validation;

public class Error
{
    public Error(ValidationErrorCode validationErrorCode)
    {
        ValidationErrorCode = validationErrorCode;
    }

    public Error(ValidationErrorCode validationErrorCode, object namedParameters) : this(validationErrorCode)
    {
        NamedParameters = namedParameters;
    }

    public ValidationErrorCode ValidationErrorCode { get; }
    public object NamedParameters { get; }
}
using Internship.Planner.Enums;

namespace Internship.Planner.Contracts.Validation;

public class Error
{
    public Error(ValidationErrorCode validationErrorCode, object namedParameters)
    {
        ValidationErrorCode = validationErrorCode;
        NamedParameters = namedParameters;
    }

    public ValidationErrorCode ValidationErrorCode { get; }
    public object NamedParameters { get; }
}
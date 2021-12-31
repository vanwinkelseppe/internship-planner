using Internship.Planner.Service.Validation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Error = Internship.Planner.Contracts.Validation.Error;
using ValidationBag = Internship.Planner.Contracts.Validation.ValidationBag;

namespace Internship.Planner.Api;

public class ValidatedActionResult<T> : IConvertToActionResult
{
    private readonly T _data;
    private readonly BaseResponse _response;

    public ValidatedActionResult(BaseResponse response, T data)
    {
        _response = response;
        _data = data;
    }

    public IActionResult Convert()
    {
        if (_response.IsValid) return new OkObjectResult(_data);

        if (_response.HasNotFoundError)
            return new NotFoundObjectResult(
                new ValidationBag(_response.Bag.Errors.Select(e =>
                    new Error(e.ValidationErrorCode, e.NamedParameters))));

        return new BadRequestObjectResult(
            new ValidationBag(_response.Bag.Errors.Select(e =>
                new Error(e.ValidationErrorCode, e.NamedParameters))));
    }
}
using Internship.Planner.Service.Validation;
using Microsoft.AspNetCore.Mvc;

namespace Internship.Planner.Api;

public static class ConvertValidatedActionResult
{
    public static IActionResult ToActionResult<TResponse, TData>(this TResponse response,
        Func<TResponse, TData> selector) where TResponse : BaseResponse
    {
        return new ValidatedActionResult<TData>(response, selector(response)).Convert();
    }
}
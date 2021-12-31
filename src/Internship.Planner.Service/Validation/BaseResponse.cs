namespace Internship.Planner.Service.Validation;

public abstract class BaseResponse
{
    public ValidationBag Bag { get; set; }
    public bool IsValid => Bag?.IsValid ?? true;
    public bool HasNotFoundError => Bag?.HasNotFoundError ?? true;
}
using FluentValidation;
using TaskEvaluation.Web.Common;

namespace TaskEvaluation.Web.Validator
{
    public class BaseValidator<T> : AbstractValidator<BaseModel>
    {
        public BaseValidator()
        {
            RuleFor(entity => entity.EntryDate).NotNull().WithMessage("Entry date is required");
            RuleFor(entity => entity.UpdateTime).NotNull().WithMessage("Update time is required");
        }
    }
}

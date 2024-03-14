using FluentValidation;
using TaskEvaluation.Web.Models;

namespace TaskEvaluation.Web.Validator
{
    public class GroupValidator : AbstractValidator<Group>
    {
        public GroupValidator()
        {
            RuleFor(group => group.Title).NotEmpty().WithMessage("Title is required");
        }
    }
}

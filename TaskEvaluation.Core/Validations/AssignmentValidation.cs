namespace TaskEvaluation.Web.Validator
{
    using FluentValidation;
    using TaskEvaluation.Web.Models;
    public class TaskValidator : AbstractValidator<Assignment>
    {
        public TaskValidator()
        {
            RuleFor(task => task.Title).NotNull().NotEmpty().WithMessage("Title is required");
            RuleFor(task => task.Description).NotNull().NotEmpty().WithMessage("Description is required");
            RuleFor(task => task.DeadLine).NotNull().NotEmpty().WithMessage("Deadline is required");
        }
    }
}
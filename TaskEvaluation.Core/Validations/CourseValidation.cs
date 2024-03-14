using FluentValidation;
using TaskEvaluation.Web.Models;

namespace TaskEvaluation.Web.Validator
{
    public class CourseValidation  : AbstractValidator<Course>
    {
        public CourseValidation() {
            RuleFor(course => course.Title).NotNull().NotEmpty().WithMessage("Title is required");
            RuleFor(course => course.IsCompleted).NotNull().NotEmpty().WithMessage("Completion status is required");
            RuleFor(c => c.Title).NotNull().NotEmpty();
        }
    }
}

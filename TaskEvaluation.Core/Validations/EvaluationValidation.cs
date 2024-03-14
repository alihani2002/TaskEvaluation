using FluentValidation;
using TaskEvaluation.Web.Models;

namespace TaskEvaluation.Web.Validator
{
    public class EvaluationGradeValidator : AbstractValidator<EvaluationGrade>
    {
        public EvaluationGradeValidator()
        {
            RuleFor(grade => grade.Grade).NotEmpty().WithMessage("Grade is required");
            RuleFor(grade => grade.Solution).NotNull().WithMessage("Solution is required");
        }
    }
}

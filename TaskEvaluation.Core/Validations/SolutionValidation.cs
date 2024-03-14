using FluentValidation;
using TaskEvaluation.Web.Models;

namespace TaskEvaluation.Web.Validator
{
    public class SolutionValidator : AbstractValidator<Solution>
    {
        public SolutionValidator()
        {
            RuleFor(s => Path.GetExtension(s.SolutionFile))
                .Matches(@"^(.png|.jpg|.jpeg|.zip|.pdf)")
                .WithMessage("Solution file must end with .png|.jpg|.jpeg|.zip|.pdf"); ;

        }


    }
}

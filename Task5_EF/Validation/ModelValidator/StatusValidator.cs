using FluentValidation;
using Task5_EF.Models;

namespace Task5_EF.Validation.ModelValidator
{
    public class StatusValidator : AbstractValidator<StatusModel>
    {
        public StatusValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
        }
    }
}
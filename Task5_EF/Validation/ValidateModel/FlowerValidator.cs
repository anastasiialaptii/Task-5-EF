using FluentValidation;
using Task5_EF.Models;

namespace Task5_EF.Validation
{
    public class FlowerValidator : AbstractValidator<FlowerModel>
    {
        public FlowerValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
        }
    }
}
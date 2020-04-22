using FluentValidation;
using Task5_EF.Models;

namespace Task5_EF.Validation.ModelValidator
{
    public class SupplyValidator : AbstractValidator<SupplyModel>
    {
        public SupplyValidator()
        {
            RuleFor(x => x.PlantationId)
                .NotEmpty()
                .WithMessage("Date should be greater or equal to current");
        }
    }
}
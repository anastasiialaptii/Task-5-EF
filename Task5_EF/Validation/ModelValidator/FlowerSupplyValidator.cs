using FluentValidation;
using Task5_EF.Models;

namespace Task5_EF.Validation.ModelValidator
{
    public class FlowerSupplyValidator : AbstractValidator<FlowerSupplyModel>
    {
        public FlowerSupplyValidator()
        {
            RuleFor(x => x.FlowerId).NotEmpty();
            RuleFor(x => x.SupplyId).NotEmpty();
            RuleFor(x => x.Amount)
                .NotEmpty()
                .GreaterThan(0)
                .WithMessage("should be greater than 0");
        }
    }
}
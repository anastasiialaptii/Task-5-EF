using FluentValidation;
using Task5_EF.Models;

namespace Task5_EF.Validation.ModelValidator
{
    public class PlantationValidator:AbstractValidator<PlantationModel>
    {
        public PlantationValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.Address).NotEmpty();
        }
    }
}
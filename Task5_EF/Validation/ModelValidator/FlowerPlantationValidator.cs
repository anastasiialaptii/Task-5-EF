﻿using FluentValidation;
using Task5_EF.Models;

namespace Task5_EF.Validation.ModelValidator
{
    public class FlowerPlantationValidator : AbstractValidator<FlowerPlantationModel>
    {
        public FlowerPlantationValidator()
        {
            RuleFor(x => x.FlowerId).NotEmpty();
            RuleFor(x => x.PlantationId).NotEmpty();
            RuleFor(x => x.Amount)
                .NotEmpty()
                .GreaterThan(0)
                .WithMessage("should be greater than 0");
        }
    }
}
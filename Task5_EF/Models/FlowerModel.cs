﻿using FluentValidation;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;


namespace Task5_EF.Models
{
    //[Validator(typeof(FlowerValidator))]
    public class FlowerModel
    {       
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<WarehouseModel> Warehouses { get; set; }

        public FlowerModel()
        {
            Warehouses = new List<WarehouseModel>();
        }
    }

    public class FlowerValidator : AbstractValidator<FlowerModel>
    {
        public FlowerValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
        }
    }

    public class ValidatorFactory : ValidatorFactoryBase
    {
        private static Dictionary<Type, IValidator> validators = new Dictionary<Type, IValidator>();

        static ValidatorFactory()
        {
            validators.Add(typeof(IValidator<FlowerModel>), new FlowerValidator());
        }

        public override IValidator CreateInstance(Type validatorType)
        {
            IValidator validator;
            if (validators.TryGetValue(validatorType, out validator))
            {
                return validator;
            }
            return validator;
        }
    }
}
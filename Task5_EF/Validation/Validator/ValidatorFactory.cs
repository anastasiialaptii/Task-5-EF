using FluentValidation;
using System;
using System.Collections.Generic;
using Task5_EF.Models;

namespace Task5_EF.Validation
{
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

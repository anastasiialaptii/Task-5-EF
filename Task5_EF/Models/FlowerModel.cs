using FluentValidation;
using FluentValidation.Attributes;
using System.Collections.Generic;


namespace Task5_EF.Models
{
    [Validator(typeof(FlowerValidator))]
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
}
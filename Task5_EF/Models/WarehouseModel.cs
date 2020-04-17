using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Task5_EF.Models
{
    public class WarehouseModel : PlaceModel
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public string Name { get; set; }

        public ICollection<FlowerModel> Flowers { get; set; }

        public WarehouseModel()
        {
            Flowers = new List<FlowerModel>();
        }
    }
}
using System.Collections.Generic;

namespace Task5_EF.Models
{
    public class WarehouseModel : PlaceModel
    { 
        public ICollection<FlowerModel> Flowers { get; set; }

        public WarehouseModel()
        {
            Flowers = new List<FlowerModel>();
        }
    }
}
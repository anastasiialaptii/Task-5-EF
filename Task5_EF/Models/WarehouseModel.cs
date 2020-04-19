using System.Collections.Generic;

namespace Task5_EF.Models
{
    public class WarehouseModel : PlaceModel
    {
        public ICollection<FlowerWarehouseModel> FlowerWarehouseModels { get; set; }

    }
}
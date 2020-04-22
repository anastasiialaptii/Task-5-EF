using System.Collections.Generic;

namespace Task5_EF.Models
{
    public class WarehouseModel : PlaceModel
    {
        public virtual IList<FlowerWarehouseModel> FlowerWarehouseModels { get; set; }

        public virtual ICollection<SupplyModel> Supply { get; set; }
    }
}
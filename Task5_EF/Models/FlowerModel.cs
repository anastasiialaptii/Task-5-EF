using System.Collections.Generic;

namespace Task5_EF.Models
{
    public class FlowerModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual IList<FlowerWarehouseModel> FlowerWarehouseModels { get; set; }
    }
}




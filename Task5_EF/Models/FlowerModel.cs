using System.Collections.Generic;

namespace Task5_EF.Models
{
    public class FlowerModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string MigrationColumn { get; set; }

        public virtual IList<FlowerWarehouseModel> FlowerWarehouseModels { get; set; }

        public virtual IList<FlowerPlantationModel> FlowerPlantationModels { get; set; }
        
        public virtual IList<FlowerSupplyModel> FlowerSupplyModels { get; set; }
    }
}




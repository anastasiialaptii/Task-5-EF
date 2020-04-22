using System.Collections.Generic;

namespace Task5_EF.Models
{
    public class PlantationModel : PlaceModel
    {
        public virtual IList<FlowerPlantationModel> FlowerPlantationModels { get; set; }

        public virtual ICollection<SupplyModel> Supply { get; set; }
    }
}
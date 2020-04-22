namespace Task5_EF.Models
{
    public class FlowerPlantationModel
    {
        public int Id { get; set; }

        public int FlowerId { get; set; }

        public FlowerModel FlowerModel { get; set; }

        public int PlantationId { get; set; }

        public PlantationModel PlantationModel { get; set; }

        public int Amount { get; set; }
    }
}
namespace Task5_EF.Models
{
    public class FlowerSupplyModel
    {
        public int Id { get; set; }

        public int FlowerId { get; set; }

        public FlowerModel FlowerModel { get; set; }

        public int SupplyId { get; set; }

        public SupplyModel SupplyModel { get; set; }

        public int Amount { get; set; }
    }
}
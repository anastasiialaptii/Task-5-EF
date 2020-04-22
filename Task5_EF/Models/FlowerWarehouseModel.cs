namespace Task5_EF.Models
{
    public class FlowerWarehouseModel
    {
        public int Id { get; set; }
       
        public int FlowerId { get; set; }

        public FlowerModel FlowerModel { get; set; }

        public int WarehouseId { get; set; }

        public WarehouseModel WarehouseModel { get; set; }

        public int Amount { get; set; }
    }
}
using System.Collections.Generic;


namespace Task5_EF.Models
{
    public class FlowerModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<WarehouseModel> Warehouses { get; set; }

        public FlowerModel()
        {
            Warehouses = new List<WarehouseModel>();
        }
    }
}
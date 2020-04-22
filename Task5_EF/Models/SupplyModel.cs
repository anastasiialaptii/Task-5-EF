using System;
using System.Collections.Generic;

namespace Task5_EF.Models
{
    public class SupplyModel
    {
        public int Id { get; set; }

        public int WarehouseId { get; set; }

        public int PlantationId { get; set; }

        public DateTime ScheduledDate { get; set; }

        public DateTime ClosedDate { get; set; }

        public int StatusId { get; set; }

        public virtual IList<FlowerSupplyModel> FlowerSupplyModels { get; set; }
    }
}
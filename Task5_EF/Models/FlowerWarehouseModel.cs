using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Task5_EF.Models
{
    public class FlowerWarehouseModel
    {
        public int FlowerId { get; set; }

        public FlowerModel FlowerModel { get; set; }

        public int WarehouseId { get; set; }

        public WarehouseModel WarehouseModel { get; set; }

        public int Amount { get; set; }
    }
}
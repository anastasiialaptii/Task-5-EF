using System.Collections.Generic;

namespace Task5_EF.Models
{
    public class StatusModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<SupplyModel> Supply { get; set; }
    }
}
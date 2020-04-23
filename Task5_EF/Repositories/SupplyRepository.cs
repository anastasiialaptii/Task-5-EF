using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using Task5_EF.IRepository;
using Task5_EF.Models;

namespace Task5_EF.Repositories
{
    public class SupplyRepository : IRepository<SupplyModel>
    {
        private SupplyContext supplyDbContext;

        public SupplyRepository(SupplyContext supplyContext)
        {
            supplyDbContext = supplyContext;
        }

        public void Create(SupplyModel item)
        {
            if (item != null)
            {
                supplyDbContext.Supplies.Add(item);
            }
        }

        public void Delete(SupplyModel item)
        {
            if (item != null)
            {
                var deleteItem = GetById(item.Id);
                if (deleteItem != null)
                {
                    supplyDbContext.Supplies.Remove(deleteItem);
                }
            }
        }

        public List<SupplyModel> GetAll()
        {
            return supplyDbContext.Supplies
                .Include(x => x.PlantationModel)
                .Include(x => x.StatusModel)
                .Include(x => x.WarehouseModel)
                .ToList();
        }

        public SupplyModel GetById(int id)
        {
            return supplyDbContext.Supplies
                .Find(id);
        }

        public void Update(SupplyModel item)
        {
            if (item != null)
            {
                var updateItem = GetById(item.Id);
                if (updateItem != null)
                {
                    updateItem.ClosedDate = item.ClosedDate;
                    updateItem.ScheduledDate = item.ScheduledDate;
                    updateItem.StatusId = item.StatusId;
                }
            }
        }
    }
}
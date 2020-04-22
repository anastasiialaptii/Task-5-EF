using System.Collections.Generic;
using System.Linq;
using Task5_EF.IRepository;
using Task5_EF.Models;
using System.Data.Entity;

namespace Task5_EF.Repositories
{
    public class FlowerSupplyRepository : IRepository<FlowerSupplyModel>
    {
        private SupplyContext supplyDbContext;

        public FlowerSupplyRepository(SupplyContext supplyContext)
        {
            supplyDbContext = supplyContext;
        }

        public void Create(FlowerSupplyModel item)
        {
            if (item != null)
            {
                supplyDbContext.FlowerSupplies.Add(item);
            }
        }

        public void Delete(FlowerSupplyModel item)
        {
            if (item != null)
            {
                var deleteItem = GetById(item.Id);
                if (deleteItem != null)
                {
                    supplyDbContext.FlowerSupplies.Remove(deleteItem);
                }
            }
        }

        public List<FlowerSupplyModel> GetAll()
        {
            return supplyDbContext.FlowerSupplies
                .Include(x => x.FlowerModel)
                .Include(x => x.SupplyModel)
                .ToList();
        }

        public FlowerSupplyModel GetById(int id)
        {
            return supplyDbContext.FlowerSupplies
                .Find(id);
        }

        public void Update(FlowerSupplyModel item)
        {
            if (item != null)
            {
                var updateItem = GetById(item.Id);
                if (updateItem != null)
                {
                    updateItem.Amount = item.Amount;
                }
            }
        }
    }
}
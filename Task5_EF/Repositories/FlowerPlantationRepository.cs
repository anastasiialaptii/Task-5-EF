using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using Task5_EF.IRepository;
using Task5_EF.Models;

namespace Task5_EF.Repositories
{
    public class FlowerPlantationRepository : IRepository<FlowerPlantationModel>
    {
        private SupplyContext supplyDbContext;

        public FlowerPlantationRepository(SupplyContext supplyContext)
        {
            supplyDbContext = supplyContext;
        }

        public void Create(FlowerPlantationModel item)
        {
            if (item != null)
            {
                supplyDbContext.FlowerPlantations
                    .Add(item);
            }
        }

        public void Delete(FlowerPlantationModel item)
        {
            if (item != null)
            {
                var deleteItem = GetById(item.Id);
                if (deleteItem != null)
                {
                    supplyDbContext.FlowerPlantations
                        .Remove(deleteItem);
                }
            }
        }

        public List<FlowerPlantationModel> GetAll()
        {
            return supplyDbContext.FlowerPlantations
                .Include(x => x.FlowerModel)
                .Include(x => x.PlantationModel)
                .ToList();
        }

        public FlowerPlantationModel GetById(int id)
        {
            return supplyDbContext.FlowerPlantations
                .Find(id);
        }

        public void Update(FlowerPlantationModel item)
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
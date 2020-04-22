using System.Collections.Generic;
using System.Linq;
using Task5_EF.IRepository;
using Task5_EF.Models;
using System.Data.Entity;

namespace Task5_EF.Repositories
{
    public class FlowerRepository : IRepository<FlowerModel>
    {
        private SupplyContext supplyDbContext;

        public FlowerRepository(SupplyContext dbContext)
        {
            supplyDbContext = dbContext;
        }

        public void Create(FlowerModel item)
        {
            if (item != null)
            {
                supplyDbContext.Flowers
                    .Add(item);
            }
        }

        public void Delete(FlowerModel item)
        {
            if (item != null)
            {
                var deleteFlower = GetById(item.Id);

                if (deleteFlower != null)
                {
                    supplyDbContext.Flowers
                        .Remove(deleteFlower);
                }
            }
        }

        public List<FlowerModel> GetAll()
        {
            return supplyDbContext.Flowers
                .Include(x => x.FlowerSupplyModels)
                .Include(x => x.FlowerWarehouseModels)
                .Include(x => x.FlowerPlantationModels)
                .ToList();
        }

        public FlowerModel GetById(int id)
        {
            return supplyDbContext.Flowers
                .Find(id);
        }

        public void Update(FlowerModel item)
        {
            if (item != null)
            {
                var updateFlower = GetById(item.Id);

                if (updateFlower != null)
                {
                    updateFlower.Name = item.Name;
                }
            }
        }
    }
}
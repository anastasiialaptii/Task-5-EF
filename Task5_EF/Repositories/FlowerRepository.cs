using System.Collections.Generic;
using System.Linq;
using Task5_EF.IRepository;
using Task5_EF.Models;

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
                supplyDbContext.Flowers.Add(item);
            }
        }

        public void Delete(FlowerModel item)
        {
            var deleteFlower = GetById(item.Id);

            if (deleteFlower != null)
            {
                supplyDbContext.Flowers.Remove(deleteFlower);
            }
        }

        public List<FlowerModel> GetAll()
        {
            return supplyDbContext.Flowers.ToList();
        }

        public FlowerModel GetById(int id)
        {
            return supplyDbContext.Flowers.Find(id);
        }

        public void Update(FlowerModel item)
        {
            var updateFlower = GetById(item.Id);

            if (updateFlower != null)
            {
                updateFlower.Name = item.Name;
            }
        }
    }
}
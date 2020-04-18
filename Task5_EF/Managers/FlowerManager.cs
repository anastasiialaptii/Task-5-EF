using System.Collections;
using System.Data.Entity;
using System.Linq;
using Task5_EF.Models;
using Task5_EF.Repository;

namespace Task5_EF.Managers
{
    public class FlowerManager : IFlowerRepository
    {
        private SupplyContext dbContext = new SupplyContext();

        public void DeleteFlower(int flowerId)
        {
            var flower = dbContext.Flowers.Find(flowerId);
            dbContext.Flowers.Remove(flower);
        }

        public FlowerModel GetFlowerById(int flowerId)
        {
            return dbContext.Flowers.Find(flowerId);
        }

        public IEnumerable GetFlowers()
        {
            return dbContext.Flowers.ToList();
        }

        public void InsertFlower(int flowerId)
        {
            var flower = dbContext.Flowers.Find(flowerId);
            dbContext.Flowers.Add(flower); 
        }

        public void Save()
        {
            dbContext.SaveChanges();
        }

        public void UpdateFlower(int flowerId)
        {
            var flower = dbContext.Flowers.Find(flowerId);
            dbContext.Entry(flower).State = EntityState.Modified;
        }
    }
}
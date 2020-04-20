using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Task5_EF.IRepository;
using Task5_EF.Models;

namespace Task5_EF.Repositories
{
    public class FlowerRepository : IRepository<FlowerModel>
    {
        private SupplyContext supplyDbContext;
        public FlowerRepository(SupplyContext dbContext)
        {
            this.supplyDbContext = dbContext;
        }

        public void Create(FlowerModel item)
        {
            supplyDbContext.Flowers.Add(item);
        }

        public void Delete(FlowerModel item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FlowerModel> GetAll()
        {
            return supplyDbContext.Flowers.ToList();
        }

        public FlowerModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(FlowerModel item)
        {
            throw new NotImplementedException();
        }
    }
}
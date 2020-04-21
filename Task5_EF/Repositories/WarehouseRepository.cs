using System.Collections.Generic;
using System.Linq;
using Task5_EF.IRepository;
using Task5_EF.Models;

namespace Task5_EF.Repositories
{
    public class WarehouseRepository : IRepository<WarehouseModel>
    {
        private SupplyContext supplyDbContext;

        public WarehouseRepository(SupplyContext supplyContext)
        {
            supplyDbContext = supplyContext;
        }

        public void Create(WarehouseModel item)
        {
            supplyDbContext.Places.Add(item);
        }

        public void Delete(WarehouseModel item)
        {
            supplyDbContext.Places.Remove(supplyDbContext.Places.Find(item.Id));
        }

        public List<WarehouseModel> GetAll()
        {
            return supplyDbContext.Places.OfType<WarehouseModel>().ToList();
        }

        public WarehouseModel GetById(int id)
        {
            return GetAll().Find(x => x.Id == id);
        }

        public void Update(WarehouseModel item)
        {
            var res = GetById(item.Id);
            res.Name = item.Name;
            res.Address = item.Address;
        }
    }
}
using System.Collections.Generic;
using System.Linq;
using Task5_EF.IRepository;
using Task5_EF.Models;

namespace Task5_EF.Repositories
{
    public class PlantationRepository : IRepository<PlantationModel>
    {
        private SupplyContext supplyDbContext;

        public PlantationRepository(SupplyContext supplyContext)
        {
            supplyDbContext = supplyContext;
        }

        public void Create(PlantationModel item)
        {
            supplyDbContext.Places.Add(item);
        }

        public void Delete(PlantationModel item)
        {
            supplyDbContext.Places.Remove(supplyDbContext.Places.Find(item.Id));
        }

        public List<PlantationModel> GetAll()
        {
            return supplyDbContext.Places.OfType<PlantationModel>().ToList();
        }

        public PlantationModel GetById(int id)
        {
            return GetAll().Find(x => x.Id == id);
        }

        public void Update(PlantationModel item)
        {
            var updatePlantation = GetById(item.Id);
            updatePlantation.Name = item.Name;
            updatePlantation.Address = item.Address;
        }
    }
}
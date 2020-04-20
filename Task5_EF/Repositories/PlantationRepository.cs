using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
            throw new NotImplementedException();
        }

        public void Delete(PlantationModel item)
        {
            throw new NotImplementedException();
        }

        public List<PlantationModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public PlantationModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(PlantationModel item)
        {
            throw new NotImplementedException();
        }
    }
}
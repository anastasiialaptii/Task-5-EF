using Task5_EF.Interfaces;
using Task5_EF.IRepository;
using Task5_EF.Models;

namespace Task5_EF.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private SupplyContext supplyDbContext;
        private FlowerRepository flowerRepository;
        private WarehouseRepository warehouseRepository;
        private PlantationRepository plantationRepository;
        private FlowerWarehouseRepository flowerWarehouseRepository;

        public UnitOfWork(SupplyContext dbContext)
        {
            supplyDbContext = dbContext;
        }


        public IRepository<FlowerModel> Flowers
        {
            get
            {
                if (flowerRepository == null)
                    flowerRepository = new FlowerRepository(supplyDbContext);
                return flowerRepository;
            }
        }

        public IRepository<WarehouseModel> Warehouses
        {
            get
            {
                if (warehouseRepository == null)
                    warehouseRepository = new WarehouseRepository(supplyDbContext);
                return warehouseRepository;
            }
        }

        public IRepository<PlantationModel> Plantations
        {
            get
            {
                if (plantationRepository == null)
                    plantationRepository = new PlantationRepository(supplyDbContext);
                return plantationRepository;
            }
        }

        public IRepository<FlowerWarehouseModel> FlowerWarehouses
        {
            get
            {
                if (flowerWarehouseRepository == null)
                    flowerWarehouseRepository = new FlowerWarehouseRepository(supplyDbContext);
                return flowerWarehouseRepository;
            }
        }

        public void Save()
        {
            supplyDbContext.SaveChanges();
        }
    }
}
using Task5_EF.IRepository;
using Task5_EF.Models;

namespace Task5_EF.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<FlowerModel> Flowers { get; }

        IRepository<WarehouseModel> Warehouses { get; }

        IRepository<PlantationModel> Plantations { get; }

        IRepository<FlowerWarehouseModel> FlowerWarehouses { get; }

        IRepository<FlowerSupplyModel> FlowerSupplies { get; }

        IRepository<FlowerPlantationModel> FlowerPlantations { get; }

        IRepository<SupplyModel> Supplies { get; }

        IRepository<StatusModel> Statuses { get; }

        void Save();
    }
}
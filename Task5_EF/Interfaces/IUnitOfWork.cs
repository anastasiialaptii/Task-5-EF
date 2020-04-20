using Task5_EF.IRepository;
using Task5_EF.Models;

namespace Task5_EF.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<FlowerModel> Flowers { get; }

        IRepository<WarehouseModel> Warehouses { get; }

        void Save();
    }
}
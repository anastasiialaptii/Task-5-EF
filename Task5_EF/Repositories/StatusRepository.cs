using System.Collections.Generic;
using System.Linq;
using Task5_EF.IRepository;
using Task5_EF.Models;

namespace Task5_EF.Repositories
{
    public class StatusRepository : IRepository<StatusModel>
    {
        private SupplyContext supplyDbContext;

        public StatusRepository(SupplyContext supplyContext)
        {
            supplyDbContext = supplyContext;
        }

        public void Create(StatusModel item)
        {
            if (item != null)
            {
                supplyDbContext.Statuses.Add(item);
            }
        }

        public void Delete(StatusModel item)
        {
            if (item != null)
            {
                var deleteItem = GetById(item.Id);
                if (deleteItem != null)
                {
                    supplyDbContext.Statuses.Remove(deleteItem);
                }
            }
        }

        public List<StatusModel> GetAll()
        {
            return supplyDbContext.Statuses.ToList();
        }

        public StatusModel GetById(int id)
        {
            return supplyDbContext.Statuses
                .Find(id);
        }

        public void Update(StatusModel item)
        {
            if (item != null)
            {
                var updateItem = GetById(item.Id);
                if (updateItem != null)
                {
                    updateItem.Name = item.Name;
                }
            }
        }
    }
}
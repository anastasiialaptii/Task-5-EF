using System.Collections.Generic;

namespace Task5_EF.IRepository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        List<TEntity> GetAll();

        TEntity GetById(int id);

        void Create(TEntity item);

        void Update(TEntity item);

        void Delete(TEntity item);
    }
}

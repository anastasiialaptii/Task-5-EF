using System.Collections.Generic;

namespace Task5_EF.IRepository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();

        TEntity GetById(int id);
        
        void Create(TEntity item);
        
        void Update(TEntity item);
        
        void Delete(TEntity item );
    }
}

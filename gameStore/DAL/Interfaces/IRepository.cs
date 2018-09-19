using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Store.DAL.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicate);
        void Create(TEntity item);
        void Update(TEntity item);
        void Delete(int id);

        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> predicate);
        
        IEnumerable<TEntity> GetWithInclude(Expression<Func<TEntity, bool>> predicate=null,
                   params Expression<Func<TEntity, object>>[] includeProperties);


    }
}

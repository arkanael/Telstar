using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telstar.Domain.Contracts.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        void BeginTransaction();
        void Commit();
        void Rollback();
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        List<TEntity> FindAll();
        TEntity FindById(int id);
    }
}
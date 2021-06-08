using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vue.DAL.Repository.Abstract
{
    public interface IRepository<TEntity> where TEntity:class
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
        void Remove(TEntity entity);
        void Add(TEntity entity);

    }
}

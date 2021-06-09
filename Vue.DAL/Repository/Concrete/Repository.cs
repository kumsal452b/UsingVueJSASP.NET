using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vue.DAL.Repository.Abstract;

namespace Vue.DAL.Repository.Concrete
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        internal DbContext dbContext;
        private readonly DbSet<TEntity> dbSet;
        public Repository(DbContext context)
        {
            this.dbContext = context;
            dbSet = dbContext.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public TEntity GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}

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
            dbSet.Add(entity);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return dbSet.ToList();
        }

        public TEntity GetById(int id)
        {
            return dbSet.Find(id);
        }

        public void Remove(TEntity entity)
        {
            dbSet.Remove(entity);
        }
    }
}

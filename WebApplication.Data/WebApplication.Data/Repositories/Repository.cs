using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace WebApplication.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity>
     where TEntity : class
    {
           protected MyDbContext _dbContext;

        public Repository(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public TEntity Get(int id)
        {
            return _dbContext.Set<TEntity>().Find(id);
        }

        public List<TEntity> GetAll()
        {
            return _dbContext.Set<TEntity>().ToList();
        }

        TEntity IRepository<TEntity>.Add(TEntity obj)
        {
            _dbContext.Set<TEntity>().Add(obj);
            SaveChanges();
            return obj;
        }

        public virtual void Update(TEntity obj)
        {
            throw new NotImplementedException();
        }


        public void Deleted(TEntity obj)
        {
            _dbContext.Set<TEntity>().Remove(obj);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {

        }


        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }

       
     
    }
}

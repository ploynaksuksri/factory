using System;
using System.Collections.Generic;
using System.Text;

namespace WebApplication.Data.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        //Task<IEnumerable<T>> GetAll();
        //Task<T> Get(int id);
        //Task Add(T obj);
        //Task Update(T obj);
        //Task Delete(int id);
        //Task SaveChanges();

        List<TEntity> GetAll();
        TEntity Get(int id);
        TEntity Add(TEntity obj);
        void Update(TEntity obj);
        void Delete(int id);
        void SaveChanges();
    }
}

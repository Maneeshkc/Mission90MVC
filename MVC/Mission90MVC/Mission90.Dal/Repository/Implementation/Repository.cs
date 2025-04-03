using Microsoft.EntityFrameworkCore;
using Mission90.Dal.Contexts;
using Mission90.Dal.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Mission90.Dal.Repository.Implementation
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbSet<T> _dbSet;
        public Repository(Mission90Context context)
        {
          _dbSet=context.Set<T>();  
        }
        public void Create(T entity)
        {
            _dbSet.Add(entity);
        }

        public T Get(Expression<Func<T, bool>> exp)
        {
         return   _dbSet.Where(exp).FirstOrDefault();
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet;
        }

        public void Remove(T entity)
        {
           _dbSet.Remove(entity);
        }
    }
}

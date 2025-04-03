using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Mission90.Dal.Repository.Interface
{
    public interface IRepository<T> where T : class
    {
        T Get(Expression<Func<T, bool>> exp);

        IEnumerable<T> GetAll();


        void Create(T entity);

        void Remove(T entity);
    }
}

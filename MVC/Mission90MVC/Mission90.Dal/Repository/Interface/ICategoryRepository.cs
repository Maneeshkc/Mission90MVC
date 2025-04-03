using Mission90.Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission90.Dal.Repository.Interface
{
    public interface ICategoryRepository:  IRepository<Category>
    {
        void Update(Category category);
    }
}

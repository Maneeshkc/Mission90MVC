using Mission90.Dal.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission90.Dal.UnitOfWork
{
    public interface IUnitOfWork
    {
        void Commit();

        ICategoryRepository Category { get; }
    }
}

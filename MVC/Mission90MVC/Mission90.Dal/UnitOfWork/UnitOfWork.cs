using Mission90.Dal.Contexts;
using Mission90.Dal.Repository.Implementation;
using Mission90.Dal.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission90.Dal.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Mission90Context _context;
        public UnitOfWork(Mission90Context context) 
        {
            _context = context;
        }
        public ICategoryRepository CategoryRepository => new CategoryRepository(_context);

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}

using Mission90.Dal.Contexts;
using Mission90.Dal.Models;
using Mission90.Dal.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission90.Dal.Repository.Implementation
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly Mission90Context _context;
        public CategoryRepository(Mission90Context context) : base(context)
        {
            _context = context;
        }

        public void Update(Category category)
        {
            _context.Update(category);
        }
    }
}

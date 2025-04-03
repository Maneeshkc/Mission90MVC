

using Microsoft.EntityFrameworkCore;
using Mission90.Dal.Models;

namespace Mission90.Dal.Contexts
{
    public class Mission90Context : DbContext
    {
        public Mission90Context(DbContextOptions optios) : base(optios) { }


        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().Property(x => x.CategoryName).IsRequired();
            modelBuilder.Entity<Category>().Property(x => x.CategoryName).HasColumnName("Category_Name");
            
        }
    }
}

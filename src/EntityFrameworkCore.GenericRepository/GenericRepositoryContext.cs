using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCore.GenericRepository
{
    public abstract class GenericRepositoryContext : DbContext
    {
        public GenericRepositoryContext(DbContextOptions options) : base(options) { }
        protected GenericRepositoryContext() : base() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
    }
}
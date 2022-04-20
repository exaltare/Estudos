using Microsoft.EntityFrameworkCore;

namespace CompugrafTest
{
    public class Context : DbContext
    {
        public DbSet<ContatoModel> Contato { get; set; }

        public Context(DbContextOptions<Context> opt) : base(opt)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}

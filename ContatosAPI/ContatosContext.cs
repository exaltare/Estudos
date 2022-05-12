using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ContatosAPI
{

    public class ContatosContext : DbContext

    {
        private IConfigurationRoot _config;
        public ContatosContext(IConfigurationRoot config, DbContextOptions options) : base(options)
        {
            _config = config;
        }

        public DbSet<Contatos> Contato { get; set; }    //passar o mapeamento ta tabela 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source =127.0.0.1,1433;Initial Catalog = DB_Contatos;User ID = sa;Password = @Suporte");
            }
        }    

        
        

    }
}

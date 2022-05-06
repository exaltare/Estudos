using Contatos.Model;
using Microsoft.EntityFrameworkCore;

namespace Contatos.Data
{
    public class Context : DbContext

    {
        public Context(DbContextOptions<Context> options) : base(options) { }
        public DbSet<DadosModel> Dados { get; set; }


    
    }

        
}

using DadosCadastrais.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace DadosCadastrais.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Contato> Contatos { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfiguration configuration = new ConfigurationBuilder()                       //instanciando a classe de configuracao
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", false, true)
                .Build();

            optionsBuilder.UseSqlServer(configuration.GetConnectionString("ServerConnection"));     //executa um metodo que vai buscar a connectionstring


        }
    }

    // "Server=localhost,1433;Database=DB_Contatos;User ID =sa;Password =@Suporte"
    // "Data Source =127.0.0.1,1433;Initial Catalog = DB_Contatos;User ID = sa;Password = @Suporte"
    // "Server=localhost,1433;Database=balta;User ID=sa;Password=1q2w3e4r@#$"

}

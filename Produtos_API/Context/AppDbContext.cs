using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Produtos_API.Models;
using System.IO;

namespace Produtos_API.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {

        }
        public DbSet<Carro> Carros { get; set; }            //serve para mapear a entidade que foi criado carro para a tabela do banco de dados 

        
    }
}


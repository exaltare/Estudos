using Microsoft.EntityFrameworkCore;
using Produtos_API.Models;

namespace Produtos_API.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Carro> Carros { get; set; }



    }
}

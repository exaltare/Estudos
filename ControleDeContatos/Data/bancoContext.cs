using ControleDeContatos.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeContatos.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)    //injeta o parametro de entrrada 

        {
        }
        public DbSet<ContatoModel> BancoContatos { get; set; }

    }
}

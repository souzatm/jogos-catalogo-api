using JogosCatalogoApi.Models;
using Microsoft.EntityFrameworkCore;

namespace JogosCatalogoApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Jogo> Jogos { get; set; }
        public DbSet<Distribuidora> Distribuidoras { get; set; }
        public DbSet<Catalogo> Catalogos { get; set; }
    }
}

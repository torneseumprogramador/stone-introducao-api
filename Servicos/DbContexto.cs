using api_stone.Models;
using Microsoft.EntityFrameworkCore;

namespace api_stone.Servicos
{
    public class DbContexto : DbContext
    {
        public DbContexto(DbContextOptions<DbContexto> options) : base(options) { }

        public DbContexto() { }

        public DbSet<Cliente> Clientes { get; set; }
    }
}
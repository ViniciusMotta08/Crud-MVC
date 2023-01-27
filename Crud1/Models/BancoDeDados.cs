using Microsoft.EntityFrameworkCore;

namespace Crud1.Models
{
    public class BancoDeDados : DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\mssqllocaldb;Database=Crud1; Integrated Security=True");
        }
    }
}

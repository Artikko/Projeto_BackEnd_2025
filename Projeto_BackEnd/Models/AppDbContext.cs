using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace Projeto_BackEnd.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
        public DbSet<Alimento> Alimentos { get; set; } 
    }
}

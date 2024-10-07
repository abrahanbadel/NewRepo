using Microsoft.EntityFrameworkCore;
using MiPrimeraAPI.Models;

namespace MiPrimeraAPI.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Persona> Persona { get; set; }
    }
}

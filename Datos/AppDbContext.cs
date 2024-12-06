using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Modelos;

namespace Datos
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
        {
    
        }
        public DbSet<PersonaModel> Personas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PersonaModel>().ToTable("Persona");
        }
    }
}

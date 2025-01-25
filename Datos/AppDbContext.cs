using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Modelos;
using System.Data;

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


        // Método para llamar al procedimiento almacenado
        public async Task<int> AccederSistemaAsync(string usuario, string contrasena)
        {
            var salidaParam = new SqlParameter("@Salida", SqlDbType.Int) { Direction = ParameterDirection.Output };
            await Database.ExecuteSqlRawAsync("EXEC Sp_Acceder_Sistema @Usuario, @Contra, @Salida OUTPUT",
                new SqlParameter("@Usuario", usuario),
                new SqlParameter("@Contra", contrasena),
                salidaParam);

            return (int)salidaParam.Value;
        }

        // Método para ejecutar Sp_Verificar_Usuario
        public async Task<bool> VerificarUsuarioAsync(string usuario)
        {
            var salidaParam = new SqlParameter("@Salida", SqlDbType.Int) { Direction = ParameterDirection.Output };
            await Database.ExecuteSqlRawAsync("EXEC Sp_Verificar_Usuario @Usuario, @Salida OUTPUT",
                new SqlParameter("@Usuario", usuario),
                salidaParam);

            return (int)salidaParam.Value == 1;
        }
    }
}

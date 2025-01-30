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
        public DbSet<UsuariosModel> Usuarios { get; set; }
        public DbSet<PermisosModel> Permisos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<PersonaModel>().ToTable("Persona");
            modelBuilder.Entity<UsuariosModel>().ToTable("Usuarios");
            modelBuilder.Entity<PermisosModel>().ToTable("Permisos"); ///Establezco la relacion de uno a muchos entres las tablas
            modelBuilder.Entity<UsuariosModel>().HasOne(u => u.Permiso).WithMany().HasForeignKey(u => u.Id_Permiso)
                .OnDelete(DeleteBehavior.SetNull);
           
            modelBuilder.Entity<Perfil_UsuarioModel>().HasNoKey(); // Indica que no es una tabla real
            
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
        public async Task<int> VerificarUsuarioAsync(string usuario)
        {
            var salidaParam = new SqlParameter("@Salida", SqlDbType.Int) { Direction = ParameterDirection.Output };
            await Database.ExecuteSqlRawAsync("EXEC Sp_Verificar_Usuario @Usuario, @Salida OUTPUT",
                new SqlParameter("@Usuario", usuario),
                salidaParam);
            return (int)salidaParam.Value;
        }

        public DbSet<Perfil_UsuarioModel> UsuariosConPermiso { get; set; }
    


        //public async Task<Perfil_UsuarioModel> BuscarUsuarioPorId(int idUsuario)
        //{
        //    var usuario = await Perfil_UsuarioModel
        //        .FromSqlRaw("EXEC Sp_Buscar_Usuario_Id @Id_usuario = {0}", idUsuario)
        //        .AsNoTracking() // Mejora el rendimiento si solo es una consulta
        //        .FirstOrDefaultAsync();

        //    return usuario;
        //}


    }
}

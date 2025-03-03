using Entidades;
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

        public async Task<(int Resultado, string MensajeError)> InsertarPersonaAsync(Persona Insertar_Persona)
        {
            // Declaración de parámetros de salida correctamente configurados
            var resultadoParam = new SqlParameter("@Resultado", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };

            var mensajeErrorParam = new SqlParameter("@MensajeError", SqlDbType.NVarChar, 255)
            {
                Direction = ParameterDirection.Output
            };

            // Ejecutar el procedimiento almacenado con parámetros de entrada y salida
            await Database.ExecuteSqlRawAsync(
                "EXEC Sp_Insertar_Persona @NoCedula, @PrimerNombre, @SegundoNombre, @PrimerApellido, @SegundoApellido, " +
                "@FechaNacimiento, @Direccion, @NoTelefono, @UsuarioCrea, @Resultado OUTPUT, @MensajeError OUTPUT",
                new SqlParameter("@NoCedula", Insertar_Persona.NoCedula),
                new SqlParameter("@PrimerNombre", Insertar_Persona.PrimerNombre), // Estaba incorrecto
                new SqlParameter("@SegundoNombre", (object)Insertar_Persona.SegundoNombre ?? DBNull.Value),
                new SqlParameter("@PrimerApellido", Insertar_Persona.PrimerApellido),
                new SqlParameter("@SegundoApellido", (object)Insertar_Persona.SegundoApellido ?? DBNull.Value),
                new SqlParameter("@FechaNacimiento", Insertar_Persona.FechaNacimiento),
                new SqlParameter("@Direccion", (object)Insertar_Persona.Direccion ?? DBNull.Value),
                new SqlParameter("@NoTelefono", (object)Insertar_Persona.NoTelefono ?? DBNull.Value),
                new SqlParameter("@UsuarioCrea", Insertar_Persona.UsuarioCrea),
                resultadoParam,  // Parámetero de salida corregido
                mensajeErrorParam // Parámetero de salida corregido
            );

            // Convertir valores de salida correctamente y devolverlos
            int resultado = (resultadoParam.Value != DBNull.Value) ? Convert.ToInt32(resultadoParam.Value) : 0;
            string mensajeError = mensajeErrorParam.Value?.ToString() ?? "Error desconocido";

            return (resultado, mensajeError);
        }

        public async Task<(int Resultado, string MensajeError)> ActualizarPersonaAsync(Persona Actualizar_Persona)
        {
            // Declaración de parámetros de salida correctamente configurados
            var resultadoParam = new SqlParameter("@Resultado", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };

            var mensajeErrorParam = new SqlParameter("@MensajeError", SqlDbType.NVarChar, 255)
            {
                Direction = ParameterDirection.Output
            };

            // Ejecutar el procedimiento almacenado con parámetros de entrada y salida
            await Database.ExecuteSqlRawAsync(
                "EXEC Sp_Actualizar_Persona @NoCedula, @PrimerNombre, @SegundoNombre, @PrimerApellido, @SegundoApellido, " +
                "@FechaNacimiento, @Direccion, @NoTelefono, @UsuarioModifica, @Resultado OUTPUT, @MensajeError OUTPUT",
                new SqlParameter("@NoCedula", Actualizar_Persona.NoCedula),
                new SqlParameter("@PrimerNombre", Actualizar_Persona.PrimerNombre),
                new SqlParameter("@SegundoNombre", (object)Actualizar_Persona.SegundoNombre ?? DBNull.Value),
                new SqlParameter("@PrimerApellido", Actualizar_Persona.PrimerApellido),
                new SqlParameter("@SegundoApellido", (object)Actualizar_Persona.SegundoApellido ?? DBNull.Value),
                new SqlParameter("@FechaNacimiento", Actualizar_Persona.FechaNacimiento),
                new SqlParameter("@Direccion", (object)Actualizar_Persona.Direccion ?? DBNull.Value),
                new SqlParameter("@NoTelefono", (object)Actualizar_Persona.NoTelefono ?? DBNull.Value),
                new SqlParameter("@UsuarioModifica", Actualizar_Persona.UsuarioCrea),
                resultadoParam,
                mensajeErrorParam
            );

            // Convertir valores de salida correctamente y devolverlos
            int resultado = (resultadoParam.Value != DBNull.Value) ? Convert.ToInt32(resultadoParam.Value) : 0;
            string mensajeError = mensajeErrorParam.Value?.ToString() ?? "Error desconocido";

            return (resultado, mensajeError);
        }

    }
}

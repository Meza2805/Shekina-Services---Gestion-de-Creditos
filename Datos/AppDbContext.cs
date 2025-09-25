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
        //public DbSet<PersonaModel> Personas { get; set; }
        public DbSet<UsuarioEntity> Usuario { get; set; }
        public DbSet<PermisoEntity> Permiso { get; set; }

        public DbSet<Persona_BaseEntity> Persona_Base { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Persona_BaseEntity>().ToTable("Persona_Base");
        }

        public async Task<List<Persona_BaseEntity>> Mostrar_Persona_Base()
        {
          var Personas = await  Persona_Base.Where(p => p.Estado == true) .ToListAsync();
            return Personas;
        }

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
                "EXEC Sp_Insertar_Persona  @NoCedula, @PrimerNombre, @SegundoNombre, @PrimerApellido, @SegundoApellido, " +
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
                "EXEC Sp_Actualizar_Persona @Id_Persona, @NoCedula, @PrimerNombre, @SegundoNombre, @PrimerApellido, @SegundoApellido, " +
                "@FechaNacimiento, @Direccion, @NoTelefono, @UsuarioModifica, @Resultado OUTPUT, @MensajeError OUTPUT",
                  new SqlParameter("@Id_Persona", Actualizar_Persona.Id),
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

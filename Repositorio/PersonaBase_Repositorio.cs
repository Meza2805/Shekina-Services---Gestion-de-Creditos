using Aplicacion;
using Entidades;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class PersonaBase_Repositorio : IRepositorio<PersonaBaseEntity>
    {
        private readonly DbContext _dbContext;

       public PersonaBase_Repositorio(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<(string, int)> Insertar_Nuevo_Registro(PersonaBaseEntity persona)
        {
            // Parámetros de entrada (respeta nombres y tipos del SP)
            var pCedula = new SqlParameter("@Cedula", (object?)persona.Cedula ?? DBNull.Value);
            var pPrimerNombre = new SqlParameter("@PrimerNombre", persona.PrimerNombre);
            var pSegundoNombre = new SqlParameter("@SegundoNombre", (object?)persona.SegundoNombre ?? DBNull.Value);
            var pPrimerApellido = new SqlParameter("@PrimerApellido", persona.PrimerApellido);
            var pSegundoApellido = new SqlParameter("@SegundoApellido", (object?)persona.SegundoApellido ?? DBNull.Value);
            var pSexo = new SqlParameter("@Sexo", persona.Sexo.ToString()); // char(1) → string(1)
            var pFoto = new SqlParameter("@Foto", (object?)persona.Foto ?? DBNull.Value);
            var pFechaNac = new SqlParameter("@FechaNacimiento", persona.FechaNacimiento.Date); // DATE
            var pIdUsuarioCrea = new SqlParameter("@Id_Usuario_Crea", persona.IdUsuarioCrea);

            // Parámetros de salida
            var pSalida = new SqlParameter("@Salida", SqlDbType.Int) { Direction = ParameterDirection.Output };
            var pMensaje = new SqlParameter("@Mensaje", SqlDbType.NVarChar, -1) { Direction = ParameterDirection.Output };

            // Ejecutar SP
            var sql = @"EXEC dbo.SP_InsertarPersona
                @Cedula, @PrimerNombre, @SegundoNombre, @PrimerApellido, @SegundoApellido,
                @Sexo, @Foto, @FechaNacimiento, @Id_Usuario_Crea, @Salida OUTPUT, @Mensaje OUTPUT";

            await _dbContext.Database.ExecuteSqlRawAsync(sql,
                pCedula, pPrimerNombre, pSegundoNombre, pPrimerApellido, pSegundoApellido,
                pSexo, pFoto, pFechaNac, pIdUsuarioCrea, pSalida, pMensaje);

            int salida = (pSalida.Value == DBNull.Value) ? 0 : (int)pSalida.Value;
            string mensaje = pMensaje.Value?.ToString() ?? string.Empty;

            return (mensaje, salida);
        }

        public Task<(string, int)> Actualizar_Registro(PersonaBaseEntity item)
        {
            throw new NotImplementedException();
        }

        public Task<(string, int)> Dar_deBaja(int id)
        {
            throw new NotImplementedException();
        }

        public Task<PersonaBaseEntity> Buscar_Registro(int id)
        {
            throw new NotImplementedException();
        }

     
    }
}

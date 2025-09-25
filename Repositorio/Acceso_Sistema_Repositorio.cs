using Aplicacion;
using Datos;
using Entidades;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class Acceso_Sistema_Repositorio : IAcessoSistema<UsuarioEntity>
    {
        private readonly AppDbContext _dbContext;

        public Acceso_Sistema_Repositorio(AppDbContext context)
        {
            _dbContext = context;
        }

        public async Task<int> Acceder_Sistema(string usuario, string contrasena)
        {
            //int resultado = await _dbContext.AccederSistemaAsync(usuario, contrasena);
            //return resultado;
            var salidaParam = new SqlParameter("@Salida", SqlDbType.Int) { Direction = ParameterDirection.Output };
            var mensajeParam = new SqlParameter("@Mensaje", SqlDbType.NVarChar, -1) { Direction = ParameterDirection.Output };
            await _dbContext.Database.ExecuteSqlRawAsync("EXEC Sp_Acceder_Sistema @Nombre_Usuario, @ContrasenaPlano, @Salida OUTPUT,@Mensaje OUTPUT",

                new SqlParameter("@Nombre_Usuario", usuario),
                new SqlParameter("@ContrasenaPlano", contrasena),
                salidaParam, mensajeParam);

            return (int)salidaParam.Value;
        }

        public async Task<int> Verificar_Usuario(string usuario)
        {
            //int resultado = await _dbContext.VerificarUsuarioAsync(usuario);
            //return resultado;
            var salidaParam = new SqlParameter("@Salida", SqlDbType.Int) { Direction = ParameterDirection.Output };
            await _dbContext.Database.ExecuteSqlRawAsync("EXEC Sp_Verificar_Usuario @Nombre_Usuario, @Salida OUTPUT",
                new SqlParameter("@Nombre_Usuario", usuario),
                salidaParam);
            return (int)salidaParam.Value;
        }

        public async Task<List<Perfil_UsuarioModel>> ObtenerUsuarios_y_Permisos()
        {
            var query = await ( from u in _dbContext.Usuario
                        join p in _dbContext.Permiso on u.Id_Permiso equals p.Id
                        select new Perfil_UsuarioModel
                        {
                            Id_Permiso = p.Id,
                            Id_Usuario = u.Id,
                            Nombre_Usuario = u.Nombre_Usuario,
                            Nombre_Permiso = p.Descripcion
                        }).ToListAsync();
            return  query;
        }

        public async Task<List<Perfil_UsuarioModel>> ObtenerUsuario_Especifico(int Id_Usuario)
        {
            var lista = await ( from u in _dbContext.Usuario.AsNoTracking()
                   join p in _dbContext.Permiso.AsNoTracking() on u.Id_Permiso equals p.Id
                   where u.Id == Id_Usuario
                   select new Perfil_UsuarioModel
                   {
                       Id_Permiso = p.Id,
                       Id_Usuario = u.Id,
                       Nombre_Usuario = u.Nombre_Usuario,
                       Nombre_Permiso = p.Descripcion
                   }
               ).ToListAsync();      // ← materializa y cierra el reader

            return lista;
        }

    }
}

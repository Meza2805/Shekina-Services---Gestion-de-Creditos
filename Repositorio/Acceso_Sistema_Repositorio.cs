using Aplicacion;
using Datos;
using Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class Acceso_Sistema_Repositorio : IAcessoSistema<AccesoSistema>
    {
        private readonly AppDbContext _dbContext;

        public Acceso_Sistema_Repositorio(AppDbContext context)
        {
            _dbContext = context;
        }

        public async Task<int> Acceder_Sistema(string usuario, string contrasena)
        {
            int resultado = await _dbContext.AccederSistemaAsync(usuario, contrasena);
            return resultado;
        }

        public async Task<int> Verificar_Usuario(string usuario)
        {
            int resultado = await _dbContext.VerificarUsuarioAsync(usuario);
            return resultado;
        }

        public async Task<List<Perfil_Usuario>> ObtenerUsuarios_y_Permisos()
        {
            var query = from u in _dbContext.Usuarios
                        join p in _dbContext.Permisos on u.Id_Permiso equals p.Id
                        select new Perfil_Usuario
                        {
                            Id_Permiso = p.Id,
                            Id_Usuario = u.Id,
                            Nombre_Usuario = u.Nombre_Usuario,
                            Permiso_Usuario = p.Descripcion
                        };
            return  await query.ToListAsync();
        }

        public async Task<List<Perfil_Usuario>> ObtenerUsuario_Especifico(int Id_Usuario)
        {
            var query = from u in _dbContext.Usuarios
                        join p in _dbContext.Permisos on u.Id_Permiso equals p.Id
                        where u.Id == Id_Usuario
                        select new Perfil_Usuario
                        {
                            Id_Permiso = p.Id,
                            Id_Usuario = u.Id,
                            Nombre_Usuario = u.Nombre_Usuario,
                            Permiso_Usuario = p.Descripcion
                        } ;
            return await query.ToListAsync();
        }
    }
}

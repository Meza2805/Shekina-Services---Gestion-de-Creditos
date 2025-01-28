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

        public async Task<bool> Verificar_Usuario(string usuario)
        {
            return await _dbContext.VerificarUsuarioAsync(usuario);
        }
    }
}

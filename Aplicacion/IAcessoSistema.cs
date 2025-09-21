using Entidades;
using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion
{
    public interface IAcessoSistema<T>
    {
        Task<int> Verificar_Usuario(string usuario);

        Task<int> Acceder_Sistema(string usuario,string contra);

        Task<List<Perfil_UsuarioModel>> ObtenerUsuarios_y_Permisos();

        Task<List<Perfil_UsuarioModel>> ObtenerUsuario_Especifico( int Id_Usuario);
    }
}

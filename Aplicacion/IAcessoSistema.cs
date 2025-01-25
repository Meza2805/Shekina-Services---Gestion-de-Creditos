using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion
{
    public interface IAcessoSistema<T>
    {
        Task<bool> Verificar_Usuario(string usuario);

        Task<bool> Acceder_Sistema(string usuario,string contra);
    }
}

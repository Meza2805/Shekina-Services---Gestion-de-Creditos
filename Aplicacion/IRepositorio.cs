using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion
{
    public interface IRepositorio<T>
    {
        Task<(string, int)> Insertar_Nuevo_Registro(T item);

        Task<(string, int)> Actualizar_Registro(T item);

        Task<(string, int)> Dar_deBaja(int id);

        Task<T> Buscar_Registro(int id);

    }

}

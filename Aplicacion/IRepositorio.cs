using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion
{
    public interface IRepositorio<T>
    {
        Task<T> ObtenerporId(int Id);
        Task<IEnumerable<T>> ObtenerListadoAsync();
        Task AgregarItem(T item);
        Task ObtenerTodos();
    }
}

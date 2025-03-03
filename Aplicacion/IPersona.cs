using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion
{
    public interface IPersona
    {
        // Método para insertar una nueva persona y retornar (Valor Generado, mensaje desde Procedimiento Almacenado SQL)
        Task<(int, string)> InsertarAsync(Persona persona);

        // Método para modificar una persona existente
        Task<(int, string)> ModificarAsync(Persona persona);

        // Método para eliminar una persona por su ID
        Task EliminarAsync(int id);
        // Método opcional para obtener una persona por su ID
        Persona ObtenerPorId(int id);

    }
}

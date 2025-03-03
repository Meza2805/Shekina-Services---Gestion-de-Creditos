using Aplicacion;
using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class PersonaRepositorio02 : IPersona
    {
        private readonly AppDbContext _dbContext;
        private int Valor = 0;
        private string Mensaje= "";
        public PersonaRepositorio02(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task EliminarAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<(int, string)> InsertarAsync(Persona persona)
        {
            (int resultado, string mensaje) = await _dbContext.InsertarPersonaAsync(persona);
            return (resultado, mensaje);
        }

        public async Task<(int, string)> ModificarAsync(Persona persona)
        {
            (int resultado, string mensaje) = await _dbContext.ActualizarPersonaAsync(persona);
            return (resultado, mensaje);
        }

        public Persona ObtenerPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}

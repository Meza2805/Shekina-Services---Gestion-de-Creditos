
using Entidades;

namespace Aplicacion
{
    public class AgregarPersona
    {
        private readonly IRepositorio<Persona> _Persona;

        public AgregarPersona(IRepositorio<Persona> repositorio_persona)
        {
            _Persona = repositorio_persona;
        }

        public async Task ExecuteAsync(Persona persona)
        {
            if (string.IsNullOrEmpty(persona.NoCedula))
            {
                throw new Exception("El número de Cedula es obligatorio!");
            }

            if (string.IsNullOrEmpty(persona.PrimerNombre))
            {
                throw new Exception("El primer nombre es obligatorio!");
            }


            if (string.IsNullOrEmpty(persona.PrimerApellido))
            {
                throw new Exception("El primer apellido es obligatorio!");
            }



            await _Persona.AgregarItem(persona);
        }
    }
}

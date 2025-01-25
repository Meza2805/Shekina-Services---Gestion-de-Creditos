using Aplicacion;
using Datos;
using Entidades;
using Microsoft.EntityFrameworkCore;
using Modelos;

namespace Repositorio
{


    public class PersonaRepositorio : IRepositorio<Persona>
    {
        private readonly AppDbContext _dbContext;

        public PersonaRepositorio ( AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        ///Este metodo recibe un modelo y lo convierte en una entidad
        public async Task AgregarItem(Persona persona)
        {
            //throw new NotImplementedException();



            /// Este codigo permite validar los nombres de las columnas de la tabla, 
            ///con los nombres del modelo respectivamente, ya que siempre existe la 
            ///posibilidad que los nombres de los paramentros del modelo sean diferentes 
            ///a los nombres de las columnas
            ///

            var PersonaModelo = new PersonaModel()
            {
                PrimerNombre = persona.PrimerNombre,
                SegundoNombre = persona.SegundoNombre,
                PrimerApellido = persona.PrimerApellido,
                SegundoApellido = persona.SegundoApellido,
                NoCedula = persona.NoCedula,
                NoTelefono = persona.NoTelefono,
                Direccion   = persona.Direccion,
                FechaNacimiento  = persona.FechaNacimiento
            };  

            await _dbContext.AddAsync(PersonaModelo);  ///Agregar los campios al modelot
            await _dbContext.SaveChangesAsync();  // Guardar los campos en la base de datos
        }

        public async Task<IEnumerable<Persona>> ObtenerListadoAsync() => 
            await _dbContext.Personas.Select (p => new Persona 
            { 
                Id = p.Id,
                PrimerNombre = p.PrimerNombre,
                SegundoNombre = p.SegundoNombre,
                PrimerApellido = p.PrimerApellido,
                SegundoApellido = p.SegundoApellido,
                NoCedula = p.NoCedula,
                NoTelefono = p.NoTelefono,
                Direccion = p.Direccion,
                FechaNacimiento = p.FechaNacimiento,
                FechaCreacion = p.FechaCreacion

            }).ToListAsync();
        public async Task<Persona> ObtenerporId(int Id)
        {
            //throw new NotImplementedException();

            var PersonaModel = await _dbContext.Personas.FindAsync(Id);  ///Buscamos por Id del Modelo
         
            return new Persona {  /// Aca retornamos una entidad
                Id = PersonaModel.Id,
                PrimerNombre = PersonaModel.PrimerNombre,
                SegundoNombre = PersonaModel.SegundoNombre,
                PrimerApellido = PersonaModel.PrimerApellido,
                SegundoApellido = PersonaModel.SegundoApellido,
                NoCedula = PersonaModel.NoCedula,
                NoTelefono = PersonaModel.NoTelefono,
                Direccion = PersonaModel.Direccion,
                FechaNacimiento = PersonaModel.FechaNacimiento
            };
        }

        Task IRepositorio<Persona>.ObtenerTodos()
        {
            throw new NotImplementedException();
        }
    }
}

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


        //Este metodo recibe un modelo y lo convierte en una entidad
        public async Task AgregarItem(PersonaBaseEntity persona)
        {
  
            var PersonaModelo = new PersonaBaseEntity()
            {
                PrimerNombre = persona.PrimerNombre,
                SegundoNombre = persona.SegundoNombre,
                PrimerApellido = persona.PrimerApellido,
                SegundoApellido = persona.SegundoApellido,
                NoCedula = persona.NoCedula,
                NoTelefono = persona.NoTelefono,
                Direccion = persona.Direccion,
                FechaNacimiento = persona.FechaNacimiento
            };

            await _dbContext.AddAsync(PersonaModelo);  ///Agregar los campios al modelot
            await _dbContext.SaveChangesAsync();  // Guardar los campos en la base de datos
        }

        //public async Task<IEnumerable<Persona>> ObtenerListadoAsync() =>
        //    await _dbContext.Personas.Select(p => new Persona
        //    {
        //        Id = p.Id,
        //        PrimerNombre = p.PrimerNombre,
        //        SegundoNombre = p.SegundoNombre,
        //        PrimerApellido = p.PrimerApellido,
        //        SegundoApellido = p.SegundoApellido,
        //        NoCedula = p.NoCedula,
        //        NoTelefono = p.NoTelefono,
        //        Direccion = p.Direccion,
        //        FechaNacimiento = p.FechaNacimiento,
        //        FechaCreacion = p.FechaCreacion

        //    }).OrderBy(p => p.PrimerNombre).ToListAsync();

        public async Task<IEnumerable<Persona>> ObtenerListadoAsync() =>
            await _dbContext.Personas
                .Select(p => new Persona
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
                    FechaCreacion = p.FechaCreacion,

                    // Join con Usuarios (Usuario Creador)
                    UsuarioCreaNombre = _dbContext.Usuarios
                        .Where(u => u.Id == p.UsuarioCrea)
                        .Select(u => u.Nombre_Usuario)
                        .FirstOrDefault(),

                    // Join con Usuarios (Usuario Modificador)
                    UsuarioModificaNombre = _dbContext.Usuarios
                        .Where(u2 => u2.Id == p.UsuarioModifica)
                        .Select(u2 => u2.Nombre_Usuario)
                        .FirstOrDefault() ?? "Sin Modificaciones",

                    // Fecha de Modificación (Si es NULL, mostrar "Sin Modificaciones")
                    FechaModificacion = p.FechaModificacion != null
                        ? p.FechaModificacion.ToString()
                        : "Sin Modificaciones"

                })
                .OrderBy(p => p.PrimerNombre)
                .ToListAsync();



        //public async Task<IEnumerable<PersonaListadoDTO>> ObtenerListadoUsuariosAsync()
        //{
        //    return await (from p in _dbContext.Personas
        //                  join u in _dbContext.Usuarios on p.UsuarioCrea equals u.Id
        //                  join u2 in _dbContext.Usuarios on p.UsuarioModifica equals u2.Id into mod
        //                  from u2 in mod.DefaultIfEmpty() // LEFT JOIN
        //                  select new PersonaListadoDTO
        //                  {
        //                      Id = p.Id,
        //                      NoCedula = p.NoCedula,
        //                      PrimerNombre = p.PrimerNombre,
        //                      SegundoNombre = p.SegundoNombre,
        //                      PrimerApellido = p.PrimerApellido,
        //                      SegundoApellido = p.SegundoApellido,
        //                      FechaNacimiento = p.FechaNacimiento,
        //                      Direccion = p.Direccion,
        //                      NoTelefono = p.NoTelefono,
        //                      FechaCreacion = p.FechaCreacion,

        //                      // Obtener nombre del usuario creador
        //                      UsuarioCreaNombre = u.Nombre_Usuario,

        //                      // Obtener nombre del usuario modificador (si es NULL, poner "Sin Modificaciones")
        //                      UsuarioModificaNombre = u2 != null ? u2.Nombre_Usuario : "Sin Modificaciones",

        //                      FechaModificacion = p.FechaModificacion
        //                  })
        //                  .OrderBy(p => p.PrimerNombre)
        //                  .ToListAsync();
        //}
        //public async Task<IEnumerable<PersonaListadoDTO>> ObtenerListadoConUsuariosAsync()
        //{
        //    return await (from p in _dbContext.Personas
        //                  join u in _dbContext.Usuarios on p.UsuarioCrea equals u.Id
        //                  join u2 in _dbContext.Usuarios on p.UsuarioModifica equals u2.Id into mod
        //                  from u2 in mod.DefaultIfEmpty() // LEFT JOIN
        //                  select new PersonaListadoDTO
        //                  {
        //                      Id = p.Id,
        //                      NoCedula = p.NoCedula,
        //                      PrimerNombre = p.PrimerNombre,
        //                      SegundoNombre = p.SegundoNombre,
        //                      PrimerApellido = p.PrimerApellido,
        //                      SegundoApellido = p.SegundoApellido,
        //                      FechaNacimiento = p.FechaNacimiento,
        //                      Direccion = p.Direccion,
        //                      NoTelefono = p.NoTelefono,
        //                      FechaCreacion = p.FechaCreacion,

        //                      // Obtener nombre del usuario creador
        //                      UsuarioCreaNombre = u.Nombre_Usuario,

        //                      // Obtener nombre del usuario modificador (si es NULL, poner "Sin Modificaciones")
        //                      UsuarioModificaNombre = u2 != null ? u2.Nombre_Usuario : "Sin Modificaciones",

        //                      FechaModificacion = p.FechaModificacion
        //                  })
        //                  .OrderBy(p => p.PrimerNombre)
        //                  .ToListAsync();
        //}


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



        public Task ObtenerTodos()
        {
            throw new NotImplementedException();
        }
    }
}

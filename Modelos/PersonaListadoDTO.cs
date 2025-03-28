using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class PersonaListadoDTO
    {
        public int Id { get; set; }
        public string NoCedula { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Direccion { get; set; }
        public string NoTelefono { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string UsuarioCreaNombre { get; set; }  // Nombre del usuario creador
        public string UsuarioModificaNombre { get; set; }  // Nombre del usuario modificador
        public DateTime? FechaModificacion { get; set; }
    }

}

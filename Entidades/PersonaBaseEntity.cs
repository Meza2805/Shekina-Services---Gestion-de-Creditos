using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PersonaBaseEntity
    {
        public int Id { get; set; }                       // PK, Identity
        public string Cedula { get; set; }                // nvarchar(16), puede ser NULL
        public string PrimerNombre { get; set; }          // nvarchar(100), NOT NULL
        public string? SegundoNombre { get; set; }         // nvarchar(100), NULL
        public string PrimerApellido { get; set; }        // nvarchar(100), NOT NULL
        public string? SegundoApellido { get; set; }       // nvarchar(100), NULL
        public char Sexo { get; set; }                    // char(1), NOT NULL
        public string? Foto { get; set; }                  // nvarchar(max), NOT NULL
        public DateTime FechaNacimiento { get; set; }     // datetime, NOT NULL
        public int IdUsuarioCrea { get; set; }            // NOT NULL
        public DateTimeOffset? FechaRegistro { get; set; }// datetimeoffset, con default GETDATE(), puede ser NULL
        public int? IdUsuarioModifica { get; set; }       // int, NULL
        public DateTimeOffset? FechaModifica { get; set; }// datetimeoffset, con default GETDATE(), puede ser NULL
        public bool? Estado { get; set; }                 // bit, default 1, puede ser NULL
    }
}

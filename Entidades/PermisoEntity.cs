using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PermisoEntity
    {
        public int Id { get; set; }                       // PK, Identity
        public string Descripcion { get; set; }           // nvarchar(450), NOT NULL
        public int IdUsuarioCrea { get; set; }            // NOT NULL
        public DateTimeOffset? FechaRegistro { get; set; }// datetimeoffset, default GETDATE(), puede ser NULL
        public int? IdUsuarioModifica { get; set; }       // int, NULL
        public DateTimeOffset? FechaModifica { get; set; }// datetimeoffset, default GETDATE(), puede ser NULL
        public bool? Estado { get; set; }                 // bit, default 1, puede ser NULL
    }
}

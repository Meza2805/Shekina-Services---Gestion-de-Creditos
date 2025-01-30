using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class PermisosModel
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public int? UsuarioCrea { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int? UsuarioModifica { get; set; }
        public bool? Estado { get; set; }
    }
}

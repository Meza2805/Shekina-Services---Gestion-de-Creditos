using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class UsuariosModel
    {
        public int Id { get; set; }
        public string Nombre_Usuario { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int UsuarioCrea { get; set; }
        public DateTime FechaModificacion { get; set; }
        public int UsuarioModifica { get; set; }
        // Clave foránea
        public int Id_Permiso { get; set; }

        // Navegación: Un usuario tiene un solo permiso
        public virtual PermisosModel Permiso { get; set; }
    }
}

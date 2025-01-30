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
        public int? Id_Permiso { get; set; }
        public string Nombre_Usuario { get; set; }
        public byte[] Contrasenia { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public int? UsuarioCrea { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int? UsuarioModifica { get; set; }
        public bool? Estado { get; set; }

        // Relación con Permiso
        public PermisosModel Permiso { get; set; }
    }
}

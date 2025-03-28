using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Perfil_UsuarioModel
    {
        public int Id { get; set; } // Corresponde a Id en la tabla
        public int? Id_Permiso { get; set; } // Puede ser nulo en la BD
        public string Nombre_Usuario { get; set; }
        public byte[] Contrasenia { get; set; } // Tipo varbinary en la BD
        public DateTime? FechaCreacion { get; set; }
        public int? UsuarioCrea { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int? UsuarioModifica { get; set; }
        public bool? Estado { get; set; } // Bit en SQL Server mapeado a bool en C#
    }
}

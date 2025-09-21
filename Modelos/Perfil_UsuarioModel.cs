using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Perfil_UsuarioModel
    {
        public int Id_Usuario { get; set; } // Corresponde a Id en la tabla
        public string Nombre_Usuario { get; set; }
        public int? Id_Permiso { get; set; } // Puede ser nulo en la BD
        public string Nombre_Permiso { get; set; }
        public byte[] Usuario_Contrasenia { get; set; } // Tipo varbinary en la BD
        public DateTime? Usuario_FechaCreacion { get; set; }
        public int? Usuario_Crea { get; set; }
        public DateTime? Usuario_FechaModificacion { get; set; }
        public int? Usuario_Modifica { get; set; }
        public bool? Usuario_Estado { get; set; } // Bit en SQL Server mapeado a bool en C#
    }
}

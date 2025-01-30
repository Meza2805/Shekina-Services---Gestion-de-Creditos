using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Perfil_Usuario
    {
        public int  Id_Usuario { get; set; }
        public int Id_Permiso { get; set; }
        public string Permiso_Usuario{ get; set; }
        public string Nombre_Usuario { get; set; }
        public bool? EstadoUsuario { get; set; }
        public bool? EstadoPermiso { get; set; }
    }
}

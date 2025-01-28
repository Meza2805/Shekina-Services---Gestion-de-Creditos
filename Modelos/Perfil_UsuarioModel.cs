using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Perfil_UsuarioModel
    {
        public int Id_Usuario { get; set; }
        public int Id_Permiso { get; set; }
        public string Permiso { get; set; }
        public string Nombre_Usuario { get; set; }
    }
}

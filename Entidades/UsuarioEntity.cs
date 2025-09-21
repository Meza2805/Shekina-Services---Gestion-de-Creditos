using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class UsuarioEntity
    {
        public int Id { get; set; }                          // PK, Identity

        // 🔹 Llaves foráneas
        public int? Id_Permiso { get; set; }                  // FK -> Permiso.Id (nullable)
        public int? Id_Persona { get; set; }                  // FK -> Persona.Id (nullable)

        // 🔹 Datos principales
        public string Nombre_Usuario { get; set; }            // nvarchar(150), NOT NULL
        public byte[] Contraseña { get; set; }               // varbinary(max), puede ser NULL
        public string Foto { get; set; }                     // nvarchar(max), puede ser NULL

        // 🔹 Auditoría
        public int Id_Usuario_Crea { get; set; }               // NOT NULL
        public DateTimeOffset? Fecha_Registro { get; set; }   // default GETDATE(), puede ser NULL
        public int? Id_Usuario_Modifica { get; set; }          // NULL
        public DateTimeOffset? Fecha_Modifica { get; set; }   // default GETDATE(), puede ser NULL
        public bool? Estado { get; set; }                    // bit, default 1, puede ser NULL

        // 🔹 Seguridad de login
        public int FailedCount { get; set; }                 // NOT NULL, default 0
        public DateTimeOffset? LastFailedAt { get; set; }    // NULL
        public DateTimeOffset? LockedUntil { get; set; }     // NULL
        public DateTimeOffset? LastLoginAt { get; set; }     // NULL

        // 🔹 Propiedades de navegación (opcionales si usas EF / ORM)
        public PermisoEntity Permiso { get; set; }
        public PersonaEntity Persona { get; set; }
    }
}

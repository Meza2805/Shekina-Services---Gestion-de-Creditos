using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PersonaEntity
    {
        public int Id { get; set; }                          // PK, Identity

        // 🔹 Llaves foráneas
        public int? IdTipoPersona { get; set; }              // FK -> Persona_Tipo.Id (nullable)
        public int? IdPersonaBase { get; set; }              // FK -> Persona_Base.Id (nullable)

        // 🔹 Auditoría
        public int IdUsuarioCrea { get; set; }               // NOT NULL
        public DateTimeOffset? FechaRegistro { get; set; }   // default GETDATE(), puede ser NULL
        public int? IdUsuarioModifica { get; set; }          // NULL
        public DateTimeOffset? FechaModifica { get; set; }   // default GETDATE(), puede ser NULL
        public bool? Estado { get; set; }                    // bit, default 1, puede ser NULL

        // 🔹 Propiedades de navegación (opcional, si usas EF u otro ORM)
        public Persona_BaseEntity PersonaBase { get; set; }
        public PersonaTipoEntity PersonaTipo { get; set; }
    }

}

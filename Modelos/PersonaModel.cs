namespace Modelos
{
    //public class PersonaModel
    //{
    //    public int Id { get; set; }
    //    public string NoCedula { get; set; }
    //    public string PrimerNombre { get; set; }
    //    public string SegundoNombre { get; set; }
    //    public string PrimerApellido { get; set; }
    //    public string SegundoApellido { get; set; }
    //    public DateTime FechaNacimiento { get; set; }
    //    public string Direccion { get; set; }
    //    public string NoTelefono { get; set; }
    //    public DateTime FechaCreacion { get;set; }
    //}
    public class Persona_BaseModel
    {
        public int Id { get; set; } // Identificador único
        public string Cedula { get; set; } // Campo obligatorio en la BD
        public string PrimerNombre { get; set; } // Campo obligatorio
        public string? SegundoNombre { get; set; } // Puede ser NULL en la BD
        public string PrimerApellido { get; set; } // Campo obligatorio
        public string? SegundoApellido { get; set; } // Puede ser NULL en la BD
        public string Sexo { get; set; } //Campo obligatorio
        public string Foto { get; set; } //Campo obligatorio
        public DateTime FechaNacimiento { get; set; } // Campo obligatorio
        public int Id_Usuario_Crea { get; set; }
        public DateTime Fecha_Registro { get; set; } // Puede ser NULL en la BD
        public int Id_Usuario_Modifica { get; set; } // Clave foránea, puede ser NULL
        public DateTime? Fecha_Modifica { get; set; } // Puede ser NULL
        public bool Estado { get; set; } = true; // Bit en SQL Server, con valor por defecto (1)
    }

}

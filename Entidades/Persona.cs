namespace Entidades
{
    public class Persona
    {
        DateTime fechaActual = DateTime.Today;
        public int Id { get; set; }
        public string NoCedula { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string  SegundoApellido { get; set; }
        public string NombreCompleto => $"{PrimerNombre} {SegundoNombre} {PrimerApellido} {SegundoApellido}";
        public DateTime FechaNacimiento { get; set; }
        public string Edad => $"{Convert.ToString(fechaActual.Year - FechaNacimiento.Year)} Años";
        public string NoTelefono { get; set; }
        public string  Direccion { get; set; }
     
        public DateTime FechaCreacion { get; set; }
      
    }

}

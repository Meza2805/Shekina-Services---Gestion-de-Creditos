namespace Modelos
{
    public class PersonaModel
    {
        public int Id { get; set; }
        public string NoCedula { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Direccion { get; set; }
        public string NoTelefono { get; set; }
        public DateTime FechaCreacion { get;set; }
    }
}

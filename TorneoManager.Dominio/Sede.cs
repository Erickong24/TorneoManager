namespace TorneoManager.Dominio
{
    public class Sede
    {
        public int IdSede { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Activo { get; set; } = "S";
    }
}

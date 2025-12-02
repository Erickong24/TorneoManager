namespace TorneoManager.Dominio
{
    public class Jugador
    {
        public int IdJugador { get; set; }
        public int IdEquipo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Posicion { get; set; }
        public int? Dorsal { get; set; }
        public string Estado { get; set; } = "ACTIVO"; // ACTIVO, SUSPENDIDO
        public string Activo { get; set; } = "S";
        
        // Propiedad de navegación opcional para mostrar nombre equipo en listas
        public string NombreEquipo { get; set; }
    }
}

namespace TorneoManager.Dominio
{
    public class Gol
    {
        public int IdGol { get; set; }
        public int IdPartido { get; set; }
        public int IdJugador { get; set; }
        public int Minuto { get; set; }
        public string Tipo { get; set; } = "NORMAL"; // NORMAL, PENAL, AUTOGOL
        
        // Propiedades de navegación (opcionales, para mostrar nombres en grillas)
        public string NombreJugador { get; set; }
    }
}

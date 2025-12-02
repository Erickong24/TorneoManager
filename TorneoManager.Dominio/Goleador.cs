namespace TorneoManager.Dominio
{
    public class Goleador
    {
        public int IdTorneo { get; set; }
        public int IdJugador { get; set; }
        public string NombreCompleto { get; set; }
        public string Equipo { get; set; }
        public int TotalGoles { get; set; }
    }
}

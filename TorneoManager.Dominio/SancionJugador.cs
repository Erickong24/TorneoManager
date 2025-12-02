namespace TorneoManager.Dominio
{
    public class SancionJugador
    {
        public int IdSancion { get; set; }
        public int IdJugador { get; set; }
        public int IdTorneo { get; set; }
        public string Motivo { get; set; }
        public int PartidosSuspendidos { get; set; }
        public int PartidosCumplidos { get; set; }
        public string Vigente { get; set; } = "S";
        
        // UI
        public string NombreJugador { get; set; }
        public string NombreEquipo { get; set; }
    }
}

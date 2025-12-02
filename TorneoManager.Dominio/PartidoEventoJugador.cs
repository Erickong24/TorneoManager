namespace TorneoManager.Dominio
{
    public class PartidoEventoJugador
    {
        public int IdEvento { get; set; }
        public int IdPartido { get; set; }
        public int IdJugador { get; set; }
        public int? MinutosJugados { get; set; }
        public int Asistencias { get; set; }
        public decimal? XgEstimado { get; set; }
        public string PosicionEnCampo { get; set; }
        public string HeatmapJson { get; set; }
        public string MvpJornada { get; set; } = "N"; // S/N
    }
}

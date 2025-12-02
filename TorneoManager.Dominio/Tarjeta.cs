namespace TorneoManager.Dominio
{
    public class Tarjeta
    {
        public int IdTarjeta { get; set; }
        public int IdPartido { get; set; }
        public int IdJugador { get; set; }
        public string Tipo { get; set; } // AMARILLA, ROJA
        public int? Minuto { get; set; }
    }
}

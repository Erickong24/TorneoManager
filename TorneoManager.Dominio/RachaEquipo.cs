namespace TorneoManager.Dominio
{
    public class RachaEquipo
    {
        public int IdRacha { get; set; }
        public int IdEquipo { get; set; }
        public int PartidosInvicto { get; set; }
        public int PartidosGanados { get; set; }
        public int GolesFavor { get; set; }
        public int GolesContra { get; set; }
        public System.DateTime? DesdeFecha { get; set; }
        public System.DateTime? HastaFecha { get; set; }
    }
}

namespace TorneoManager.Dominio
{
    public class PartidoReprogramacion
    {
        public int IdReprogramacion { get; set; }
        public int IdPartido { get; set; }
        public System.DateTime? FechaAnterior { get; set; }
        public System.DateTime FechaNueva { get; set; }
        public string Motivo { get; set; }
        public string Notificado { get; set; } = "N";
    }
}

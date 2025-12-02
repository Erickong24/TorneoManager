namespace TorneoManager.Dominio
{
    public class Arbitro
    {
        public int IdArbitro { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; } = "PRINCIPAL"; // PRINCIPAL, ASISTENTE, VEEDOR
        public string Activo { get; set; } = "S";
    }
}

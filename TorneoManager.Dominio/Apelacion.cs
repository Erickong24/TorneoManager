namespace TorneoManager.Dominio
{
    public class Apelacion
    {
        public int IdApelacion { get; set; }
        public int IdSancion { get; set; }
        public string Estado { get; set; } = "PENDIENTE"; // PENDIENTE, APROBADA, RECHAZADA
        public string Motivo { get; set; }
        public string Respuesta { get; set; }
        public System.DateTime? FechaPresentacion { get; set; }
        public System.DateTime? FechaResolucion { get; set; }
    }
}

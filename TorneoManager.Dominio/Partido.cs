using System;

namespace TorneoManager.Dominio
{
    public class Partido
    {
        public int IdPartido { get; set; }
        public int IdTorneo { get; set; }
        public int IdLocal { get; set; }
        public int IdVisitante { get; set; }
        public int? IdSede { get; set; }
        public DateTime? Fecha { get; set; }
        public int? Jornada { get; set; }
        public int GolesLocal { get; set; }
        public int GolesVisitante { get; set; }
        public string Estado { get; set; } = "PROGRAMADO"; // PROGRAMADO, JUGADO, SUSPENDIDO
        public string FormacionLocal { get; set; }
        public string FormacionVisitante { get; set; }

        // Propiedades de navegación para UI
        public string NombreTorneo { get; set; }
        public string NombreLocal { get; set; }
        public string NombreVisitante { get; set; }
        public string NombreSede { get; set; }
    }
}

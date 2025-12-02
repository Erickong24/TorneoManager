using System.Collections.Generic;
using TorneoManager.Dominio;
using TorneoManager.Entity;

namespace TorneoManager.Logic
{
    public class ReportesService
    {
        private readonly IReporteRepositorio _reporteRepositorio;

        public ReportesService()
        {
            _reporteRepositorio = new ReporteRepositorio();
        }

        public List<Posicion> ObtenerTablaPosiciones(int idTorneo)
        {
            return _reporteRepositorio.ObtenerTablaPosiciones(idTorneo);
        }

        public List<Goleador> ObtenerGoleadores(int idTorneo)
        {
            return _reporteRepositorio.ObtenerGoleadores(idTorneo);
        }

        public List<SancionJugador> ObtenerSancionados(int idTorneo)
        {
            return _reporteRepositorio.ObtenerSancionados(idTorneo);
        }

        public List<FairPlayEntry> ObtenerFairPlay(int idTorneo)
        {
            return _reporteRepositorio.ObtenerFairPlay(idTorneo);
        }
    }
}

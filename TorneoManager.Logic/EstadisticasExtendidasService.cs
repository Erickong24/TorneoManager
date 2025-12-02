using System.Collections.Generic;
using TorneoManager.Dominio;
using TorneoManager.Entity;

namespace TorneoManager.Logic
{
    public class EstadisticasExtendidasService
    {
        private readonly IEstadisticaRepositorio _repo;

        public EstadisticasExtendidasService()
        {
            _repo = new EstadisticaRepositorio();
        }

        public void RegistrarEventoJugador(PartidoEventoJugador evento)
        {
            _repo.RegistrarEventoJugador(evento);
        }

        public List<PartidoEventoJugador> ListarEventosPorPartido(int idPartido)
        {
            return _repo.ListarEventosPorPartido(idPartido);
        }

        public List<RachaEquipo> ListarRachas(int idTorneo)
        {
            return _repo.ListarRachas(idTorneo);
        }
    }
}

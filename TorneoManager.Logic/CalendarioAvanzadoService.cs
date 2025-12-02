using System.Collections.Generic;
using TorneoManager.Dominio;
using TorneoManager.Entity;

namespace TorneoManager.Logic
{
    public class CalendarioAvanzadoService
    {
        private readonly ICalendarioRepositorio _repo;

        public CalendarioAvanzadoService()
        {
            _repo = new CalendarioRepositorio();
        }

        public int ReprogramarPartido(PartidoReprogramacion reprog)
        {
            return _repo.InsertarReprogramacion(reprog);
        }

        public List<PartidoReprogramacion> ListarReprogramaciones(int idPartido)
        {
            return _repo.ListarReprogramaciones(idPartido);
        }

        public void RegistrarArbitraje(PartidoArbitraje arbitraje)
        {
            _repo.RegistrarArbitraje(arbitraje);
        }

        public List<PartidoArbitraje> ListarArbitrajes(int idPartido)
        {
            return _repo.ListarArbitrajes(idPartido);
        }
    }
}

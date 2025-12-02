using System.Collections.Generic;
using TorneoManager.Dominio;
using TorneoManager.Entity;

namespace TorneoManager.Logic
{
    public class GestionTorneosService
    {
        private readonly ITorneoRepositorio _torneoRepositorio;

        public GestionTorneosService()
        {
            _torneoRepositorio = new TorneoRepositorio();
        }

        public List<Torneo> ListarTorneos()
        {
            return _torneoRepositorio.Listar();
        }

        public void GuardarTorneo(Torneo torneo)
        {
            if (torneo.IdTorneo == 0)
            {
                _torneoRepositorio.Insertar(torneo);
            }
            else
            {
                _torneoRepositorio.Actualizar(torneo);
            }
        }

        public void EliminarTorneo(int id)
        {
            _torneoRepositorio.Eliminar(id);
        }
    }
}

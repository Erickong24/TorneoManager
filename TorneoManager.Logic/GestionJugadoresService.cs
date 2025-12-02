using System.Collections.Generic;
using TorneoManager.Dominio;
using TorneoManager.Entity;

namespace TorneoManager.Logic
{
    public class GestionJugadoresService
    {
        private readonly IJugadorRepositorio _jugadorRepositorio;

        public GestionJugadoresService()
        {
            _jugadorRepositorio = new JugadorRepositorio();
        }

        public List<Jugador> ListarJugadores(int idEquipo)
        {
            return _jugadorRepositorio.Listar(idEquipo);
        }

        public void GuardarJugador(Jugador jugador)
        {
            if (jugador.IdJugador == 0)
            {
                _jugadorRepositorio.Insertar(jugador);
            }
            else
            {
                _jugadorRepositorio.Actualizar(jugador);
            }
        }

        public void CambiarEstado(int id, bool activo)
        {
            _jugadorRepositorio.CambiarEstado(id, activo);
        }
    }
}

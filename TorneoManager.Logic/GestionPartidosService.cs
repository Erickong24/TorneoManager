using System.Collections.Generic;
using TorneoManager.Dominio;
using TorneoManager.Entity;

namespace TorneoManager.Logic
{
    public class GestionPartidosService
    {
        private readonly IPartidoRepositorio _partidoRepositorio;
        private readonly ITarjetaRepositorio _tarjetaRepositorio;
        private readonly IGolRepositorio _golRepositorio;

        public GestionPartidosService()
        {
            _partidoRepositorio = new PartidoRepositorio();
            _tarjetaRepositorio = new TarjetaRepositorio();
            _golRepositorio = new GolRepositorio();
        }

        public List<Partido> ListarPartidos(int idTorneo)
        {
            return _partidoRepositorio.Listar(idTorneo);
        }

        public Partido ObtenerPartido(int idPartido)
        {
            return _partidoRepositorio.Obtener(idPartido);
        }

        public void ProgramarPartido(Partido partido)
        {
            if (partido.IdPartido == 0)
            {
                _partidoRepositorio.Insertar(partido);
            }
            else
            {
                _partidoRepositorio.Actualizar(partido);
            }
        }

        public void RegistrarResultado(int idPartido, int golesLocal, int golesVisitante, string usuario)
        {
            _partidoRepositorio.RegistrarResultado(idPartido, golesLocal, golesVisitante, usuario);
        }

        public void RegistrarTarjeta(Tarjeta tarjeta)
        {
            _tarjetaRepositorio.Insertar(tarjeta);
        }

        public List<Tarjeta> ListarTarjetas(int idPartido)
        {
            return _tarjetaRepositorio.Listar(idPartido);
        }

        public void RegistrarGol(Gol gol)
        {
            _golRepositorio.Insertar(gol);
        }

        public List<Gol> ListarGoles(int idPartido)
        {
            return _golRepositorio.Listar(idPartido);
        }
    }
}

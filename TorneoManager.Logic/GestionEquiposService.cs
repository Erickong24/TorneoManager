using System.Collections.Generic;
using TorneoManager.Dominio;
using TorneoManager.Entity;

namespace TorneoManager.Logic
{
    public class GestionEquiposService
    {
        private readonly IEquipoRepositorio _equipoRepositorio;

        public GestionEquiposService()
        {
            _equipoRepositorio = new EquipoRepositorio();
        }

        public List<Equipo> ListarEquipos(int idTorneo)
        {
            return _equipoRepositorio.Listar(idTorneo);
        }

        public Equipo ObtenerEquipo(int idEquipo)
        {
            return _equipoRepositorio.Obtener(idEquipo);
        }

        public void GuardarEquipo(Equipo equipo)
        {
            if (equipo.IdEquipo == 0)
            {
                _equipoRepositorio.Insertar(equipo);
            }
            else
            {
                _equipoRepositorio.Actualizar(equipo);
            }
        }

        public void CambiarEstado(int id, bool activo)
        {
            _equipoRepositorio.CambiarEstado(id, activo);
        }
    }
}

using System.Collections.Generic;
using TorneoManager.Dominio;
using TorneoManager.Entity;

namespace TorneoManager.Logic
{
    public class SedesService
    {
        private readonly ISedeRepositorio _repo;

        public SedesService()
        {
            _repo = new SedeRepositorio();
        }

        public List<Sede> Listar() => _repo.Listar();

        public int Guardar(Sede sede)
        {
            if (sede.IdSede == 0)
                return _repo.Insertar(sede);

            _repo.Actualizar(sede);
            return sede.IdSede;
        }
    }
}

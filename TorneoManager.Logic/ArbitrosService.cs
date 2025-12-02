using System.Collections.Generic;
using TorneoManager.Dominio;
using TorneoManager.Entity;

namespace TorneoManager.Logic
{
    public class ArbitrosService
    {
        private readonly IArbitroRepositorio _repo;

        public ArbitrosService()
        {
            _repo = new ArbitroRepositorio();
        }

        public List<Arbitro> Listar() => _repo.Listar();

        public int Guardar(Arbitro arbitro)
        {
            if (arbitro.IdArbitro == 0)
                return _repo.Insertar(arbitro);

            _repo.Actualizar(arbitro);
            return arbitro.IdArbitro;
        }
    }
}

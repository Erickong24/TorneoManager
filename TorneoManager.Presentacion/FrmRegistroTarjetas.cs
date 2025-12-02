using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TorneoManager.Logic;
using TorneoManager.Dominio;

namespace TorneoManager.Presentacion
{
    public partial class FrmRegistroTarjetas : Form
    {
        private int _idPartido;
        private GestionPartidosService _partidoService;
        private GestionJugadoresService _jugadorService;
        private GestionEquiposService _equipoService;
        private Partido _partido;

        public FrmRegistroTarjetas(int idPartido)
        {
            InitializeComponent();
            _idPartido = idPartido;
            _partidoService = new GestionPartidosService();
            _jugadorService = new GestionJugadoresService();
            _equipoService = new GestionEquiposService();
        }

        private void FrmRegistroTarjetas_Load(object sender, EventArgs e)
        {
            Tema.AplicarEstiloBoton(btnAgregar, true);
            Tema.AplicarEstiloGrid(dgvTarjetas);
            
            CargarDatosPartido();
            CargarTarjetas();
        }

        private void CargarDatosPartido()
        {
            _partido = _partidoService.ObtenerPartido(_idPartido);

            if (_partido != null)
            {
                var equipos = new List<Equipo>();
                var equipoLocal = _equipoService.ObtenerEquipo(_partido.IdLocal);
                var equipoVisitante = _equipoService.ObtenerEquipo(_partido.IdVisitante);

                if (equipoLocal != null) equipos.Add(equipoLocal);
                if (equipoVisitante != null) equipos.Add(equipoVisitante);

                cboEquipo.DataSource = equipos;
                cboEquipo.DisplayMember = "Nombre";
                cboEquipo.ValueMember = "IdEquipo";
            }
        }

        private void cboEquipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboEquipo.SelectedValue == null || !(cboEquipo.SelectedValue is int)) return;
            int idEquipo = (int)cboEquipo.SelectedValue;
            cboJugador.DataSource = _jugadorService.ListarJugadores(idEquipo);
            cboJugador.DisplayMember = "Nombre"; // Deberia ser Nombre + Apellido, pero el binding es simple
            cboJugador.ValueMember = "IdJugador";
        }

        private void CargarTarjetas()
        {
            dgvTarjetas.DataSource = _partidoService.ListarTarjetas(_idPartido);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cboJugador.SelectedValue == null || cboTipo.SelectedItem == null)
            {
                MessageBox.Show("Seleccione jugador y tipo.");
                return;
            }

            if (!int.TryParse(txtMinuto.Text, out int minuto))
            {
                MessageBox.Show("Ingrese un minuto válido.");
                return;
            }

            try
            {
                var tarjeta = new Tarjeta
                {
                    IdPartido = _idPartido,
                    IdJugador = (int)cboJugador.SelectedValue,
                    Tipo = cboTipo.SelectedItem.ToString(),
                    Minuto = minuto
                };

                _partidoService.RegistrarTarjeta(tarjeta);
                MessageBox.Show("Tarjeta registrada.");
                CargarTarjetas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}

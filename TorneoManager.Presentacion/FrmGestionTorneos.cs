using System;
using System.Windows.Forms;
using TorneoManager.Logic;
using TorneoManager.Dominio;

namespace TorneoManager.Presentacion
{
    public partial class FrmGestionTorneos : Form
    {
        private GestionTorneosService _service;
        private int _idTorneoSeleccionado = 0;

        public FrmGestionTorneos()
        {
            InitializeComponent();
            _service = new GestionTorneosService();
        }

        private void FrmGestionTorneos_Load(object sender, EventArgs e)
        {
            Tema.AplicarEstiloBoton(btnGuardar, true);
            Tema.AplicarEstiloBoton(btnEliminar, false);
            Tema.AplicarEstiloBoton(btnNuevo, false);
            Tema.AplicarEstiloGrid(dgvTorneos);
            
            CargarTorneos();
        }

        private void CargarTorneos()
        {
            try
            {
                dgvTorneos.DataSource = _service.ListarTorneos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar torneos: " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var torneo = new Torneo
                {
                    IdTorneo = _idTorneoSeleccionado,
                    Nombre = txtNombre.Text,
                    FechaInicio = dtpFechaInicio.Value,
                    FechaFin = dtpFechaFin.Value
                };

                _service.GuardarTorneo(torneo);
                MessageBox.Show("Torneo guardado correctamente.");
                CargarTorneos();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_idTorneoSeleccionado == 0) return;

            if (MessageBox.Show("¿Está seguro de eliminar este torneo?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    _service.EliminarTorneo(_idTorneoSeleccionado);
                    CargarTorneos();
                    Limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            _idTorneoSeleccionado = 0;
            txtNombre.Text = "";
            dtpFechaInicio.Value = DateTime.Now;
            dtpFechaFin.Value = DateTime.Now;
        }

        private void dgvTorneos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTorneos.SelectedRows.Count > 0)
            {
                var row = dgvTorneos.SelectedRows[0];
                var torneo = (Torneo)row.DataBoundItem;
                _idTorneoSeleccionado = torneo.IdTorneo;
                txtNombre.Text = torneo.Nombre;
                dtpFechaInicio.Value = torneo.FechaInicio ?? DateTime.Now;
                dtpFechaFin.Value = torneo.FechaFin ?? DateTime.Now;
            }
        }
    }
}

using System;
using System.Windows.Forms;
using TorneoManager.Logic;
using TorneoManager.Dominio;

namespace TorneoManager.Presentacion
{
    public partial class FrmGestionEquipos : Form
    {
        private GestionEquiposService _equipoService;
        private GestionTorneosService _torneoService;
        private int _idEquipoSeleccionado = 0;

        public FrmGestionEquipos()
        {
            InitializeComponent();
            _equipoService = new GestionEquiposService();
            _torneoService = new GestionTorneosService();
        }

        private void FrmGestionEquipos_Load(object sender, EventArgs e)
        {
            Tema.AplicarEstiloBoton(btnGuardar, true);
            Tema.AplicarEstiloBoton(btnNuevo, false);
            Tema.AplicarEstiloGrid(dgvEquipos);
            CargarTorneos();
        }

        private void CargarTorneos()
        {
            try
            {
                cboTorneos.DataSource = _torneoService.ListarTorneos();
                cboTorneos.DisplayMember = "Nombre";
                cboTorneos.ValueMember = "IdTorneo";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar torneos: " + ex.Message);
            }
        }

        private void cboTorneos_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarEquipos();
        }

        private void CargarEquipos()
        {
            if (cboTorneos.SelectedValue == null || !(cboTorneos.SelectedValue is int)) return;

            try
            {
                int idTorneo = (int)cboTorneos.SelectedValue;
                dgvEquipos.DataSource = _equipoService.ListarEquipos(idTorneo);
            }
            catch (Exception ex)
            {
                // Ignorar error de conversion inicial
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cboTorneos.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un torneo.");
                return;
            }

            try
            {
                var equipo = new Equipo
                {
                    IdEquipo = _idEquipoSeleccionado,
                    IdTorneo = (int)cboTorneos.SelectedValue,
                    Nombre = txtNombre.Text,
                    Ciudad = txtCiudad.Text,
                    Tecnico = txtTecnico.Text,
                    Activo = chkActivo.Checked ? "S" : "N"
                };

                _equipoService.GuardarEquipo(equipo);
                MessageBox.Show("Equipo guardado correctamente.");
                CargarEquipos();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            _idEquipoSeleccionado = 0;
            txtNombre.Text = "";
            txtCiudad.Text = "";
            txtTecnico.Text = "";
            chkActivo.Checked = true;
        }

        private void dgvEquipos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEquipos.SelectedRows.Count > 0)
            {
                var row = dgvEquipos.SelectedRows[0];
                var equipo = (Equipo)row.DataBoundItem;
                _idEquipoSeleccionado = equipo.IdEquipo;
                txtNombre.Text = equipo.Nombre;
                txtCiudad.Text = equipo.Ciudad;
                txtTecnico.Text = equipo.Tecnico;
                chkActivo.Checked = equipo.Activo == "S";
            }
        }
    }
}

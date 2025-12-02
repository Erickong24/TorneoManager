using System;
using System.Windows.Forms;
using TorneoManager.Logic;

namespace TorneoManager.Presentacion
{
    public partial class FrmTablaPosiciones : Form
    {
        private GestionTorneosService _torneoService;
        private ReportesService _reportesService;

        public FrmTablaPosiciones()
        {
            InitializeComponent();
            _torneoService = new GestionTorneosService();
            _reportesService = new ReportesService();
        }

        private void FrmTablaPosiciones_Load(object sender, EventArgs e)
        {
            Tema.AplicarEstiloBoton(btnActualizar, true);
            Tema.AplicarEstiloGrid(dgvPosiciones);
            Tema.AplicarEstiloGrid(dgvGoleadores);
            Tema.AplicarEstiloGrid(dgvSanciones);
            Tema.AplicarEstiloGrid(dgvFairPlay);
            
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
            CargarDatos();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            if (cboTorneos.SelectedValue == null || !(cboTorneos.SelectedValue is int)) return;
            int idTorneo = (int)cboTorneos.SelectedValue;

            try
            {
                if (tabControl1.SelectedTab == tabPosiciones)
                {
                    dgvPosiciones.DataSource = _reportesService.ObtenerTablaPosiciones(idTorneo);
                }
                else if (tabControl1.SelectedTab == tabGoleadores)
                {
                    dgvGoleadores.DataSource = _reportesService.ObtenerGoleadores(idTorneo);
                }
                else if (tabControl1.SelectedTab == tabSanciones)
                {
                    dgvSanciones.DataSource = _reportesService.ObtenerSancionados(idTorneo);
                }
                else if (tabControl1.SelectedTab == tabFairPlay)
                {
                    dgvFairPlay.DataSource = _reportesService.ObtenerFairPlay(idTorneo);
                }
            }
            catch (Exception ex)
            {
                // Ignorar o mostrar error en status bar
            }
        }
    }
}

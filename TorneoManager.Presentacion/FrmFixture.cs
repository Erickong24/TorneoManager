using System;
using System.Linq;
using System.Windows.Forms;
using TorneoManager.Dominio;
using TorneoManager.Logic;

namespace TorneoManager.Presentacion
{
    public partial class FrmFixture : Form
    {
        private GestionPartidosService _partidoService;
        private GestionTorneosService _torneoService;
        private GestionEquiposService _equipoService;
        private CalendarioAvanzadoService _calendarioService;
        private ArbitrosService _arbitrosService;
        private SedesService _sedesService;
        private int _idPartidoSeleccionado = 0;
        private Partido _partidoActual;

        public FrmFixture()
        {
            InitializeComponent();
            _partidoService = new GestionPartidosService();
            _torneoService = new GestionTorneosService();
            _equipoService = new GestionEquiposService();
            _calendarioService = new CalendarioAvanzadoService();
            _arbitrosService = new ArbitrosService();
            _sedesService = new SedesService();
        }

        private void FrmFixture_Load(object sender, EventArgs e)
        {
            Tema.AplicarEstiloBoton(btnProgramar, true);
            Tema.AplicarEstiloBoton(btnResultado, true);
            Tema.AplicarEstiloBoton(btnTarjetas, false);
            Tema.AplicarEstiloBoton(btnGoles, false);
            Tema.AplicarEstiloBoton(btnReprogramar, false);
            Tema.AplicarEstiloGrid(dgvPartidos);

            CargarTorneos();
            CargarArbitros();
            CargarSedes();
        }

        private void CargarTorneos()
        {
            try
            {
                cboTorneos.DataSource = _torneoService.ListarTorneos();
                cboTorneos.DisplayMember = "Nombre";
                cboTorneos.ValueMember = "IdTorneo";
                if (cboTorneos.Items.Count > 0)
                {
                    cboTorneos.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar torneos: " + ex.Message);
            }
        }

        private void cboTorneos_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarEquipos();
            CargarPartidos();
        }

        private void CargarEquipos()
        {
            if (cboTorneos.SelectedValue == null || !(cboTorneos.SelectedValue is int)) return;
            int idTorneo = (int)cboTorneos.SelectedValue;

            try
            {
                cboLocal.DataSource = _equipoService.ListarEquipos(idTorneo);
                cboLocal.DisplayMember = "Nombre";
                cboLocal.ValueMember = "IdEquipo";

                cboVisitante.DataSource = _equipoService.ListarEquipos(idTorneo).ToList();
                cboVisitante.DisplayMember = "Nombre";
                cboVisitante.ValueMember = "IdEquipo";

                if (cboLocal.Items.Count > 0) cboLocal.SelectedIndex = 0;
                if (cboVisitante.Items.Count > 0) cboVisitante.SelectedIndex = Math.Min(1, cboVisitante.Items.Count - 1);
            }
            catch (Exception)
            {
                // Ignorar carga inicial
            }
        }

        private void CargarArbitros()
        {
            try
            {
                var arbitros = _arbitrosService.Listar();
                cboArbitro.DataSource = arbitros;
                cboArbitro.DisplayMember = "Nombre";
                cboArbitro.ValueMember = "IdArbitro";
                cboArbitro.SelectedIndex = arbitros.Count > 0 ? 0 : -1;
            }
            catch (Exception)
            {
                // Ignorar
            }
        }

        private void CargarSedes()
        {
            try
            {
                var sedes = _sedesService.Listar();
                cboSede.DataSource = sedes;
                cboSede.DisplayMember = "Nombre";
                cboSede.ValueMember = "IdSede";
                cboSede.SelectedIndex = sedes.Count > 0 ? 0 : -1;
            }
            catch (Exception)
            {
                // Ignorar
            }
        }

        private void CargarPartidos()
        {
            if (cboTorneos.SelectedValue == null || !(cboTorneos.SelectedValue is int)) return;
            int idTorneo = (int)cboTorneos.SelectedValue;

            try
            {
                var data = _partidoService.ListarPartidos(idTorneo);
                dgvPartidos.DataSource = data;
                if (dgvPartidos.Rows.Count > 0)
                {
                    dgvPartidos.ClearSelection();
                    dgvPartidos.Rows[0].Selected = true;
                    dgvPartidos_SelectionChanged(dgvPartidos, EventArgs.Empty);
                }
                else
                {
                    _idPartidoSeleccionado = 0;
                    _partidoActual = null;
                }
            }
            catch (Exception)
            {
                // Ignorar
            }
        }

        private void btnProgramar_Click(object sender, EventArgs e)
        {
            if (cboTorneos.SelectedValue == null || cboLocal.SelectedValue == null || cboVisitante.SelectedValue == null)
            {
                MessageBox.Show("Seleccione torneo y equipos.");
                return;
            }

            if ((int)cboLocal.SelectedValue == (int)cboVisitante.SelectedValue)
            {
                MessageBox.Show("El equipo local y visitante no pueden ser el mismo.");
                return;
            }

            try
            {
                var partido = new Partido
                {
                    IdTorneo = (int)cboTorneos.SelectedValue,
                    IdLocal = (int)cboLocal.SelectedValue,
                    IdVisitante = (int)cboVisitante.SelectedValue,
                    IdSede = cboSede.SelectedValue as int?,
                    Fecha = dtpFecha.Value,
                    Jornada = int.TryParse(txtJornada.Text, out int j) ? j : 1,
                    FormacionLocal = cboFormacionLocal.Text,
                    FormacionVisitante = cboFormacionVisitante.Text
                };

                _partidoService.ProgramarPartido(partido);

                if (partido.IdPartido != 0 && cboArbitro.SelectedValue is int idArb)
                {
                    _calendarioService.RegistrarArbitraje(new PartidoArbitraje
                    {
                        IdPartido = partido.IdPartido,
                        IdArbitro = idArb,
                        Rol = "PRINCIPAL"
                    });
                }

                MessageBox.Show("Partido programado.");
                CargarPartidos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al programar: " + ex.Message);
            }
        }

        private void dgvPartidos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPartidos.SelectedRows.Count > 0)
            {
                var row = dgvPartidos.SelectedRows[0];
                var partido = (Partido)row.DataBoundItem;
                _partidoActual = partido;
                _idPartidoSeleccionado = partido.IdPartido;
                lblPartidoSeleccionado.Text = $"{partido.NombreLocal} vs {partido.NombreVisitante}";
                txtGolesLocal.Text = partido.GolesLocal.ToString();
                txtGolesVisitante.Text = partido.GolesVisitante.ToString();
                dtpReprogramar.Value = partido.Fecha ?? DateTime.Now;
                dtpFecha.Value = partido.Fecha ?? DateTime.Now;
                txtJornada.Text = partido.Jornada?.ToString() ?? "1";

                if (partido.IdSede.HasValue)
                {
                    cboSede.SelectedValue = partido.IdSede.Value;
                }
                else
                {
                    cboSede.SelectedIndex = -1;
                }

                try
                {
                    var arbitrajes = _calendarioService.ListarArbitrajes(_idPartidoSeleccionado);
                    var principal = arbitrajes.Find(a => a.Rol == "PRINCIPAL");
                    if (principal != null)
                    {
                        cboArbitro.SelectedValue = principal.IdArbitro;
                    }
                    else
                    {
                        cboArbitro.SelectedIndex = -1;
                    }
                }
                catch (Exception)
                {
                    cboArbitro.SelectedIndex = -1;
                }
            }
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            if (_idPartidoSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un partido.");
                return;
            }

            if (!int.TryParse(txtGolesLocal.Text, out int gl) || !int.TryParse(txtGolesVisitante.Text, out int gv))
            {
                MessageBox.Show("Ingrese goles válidos para ambos equipos.");
                return;
            }

            try
            {
                _partidoService.RegistrarResultado(_idPartidoSeleccionado, gl, gv, "ADMIN"); // Usuario hardcoded
                MessageBox.Show("Resultado registrado.");
                CargarPartidos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar resultado: " + ex.Message);
            }
        }

        private void btnTarjetas_Click(object sender, EventArgs e)
        {
            if (_idPartidoSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un partido.");
                return;
            }

            var frm = new FrmRegistroTarjetas(_idPartidoSeleccionado);
            frm.ShowDialog();
        }

        private void btnGoles_Click(object sender, EventArgs e)
        {
            if (_idPartidoSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un partido.");
                return;
            }

            var frm = new FrmRegistroGoles(_idPartidoSeleccionado);
            frm.ShowDialog();
        }

        private void btnReprogramar_Click(object sender, EventArgs e)
        {
            if (_idPartidoSeleccionado == 0 || _partidoActual == null)
            {
                MessageBox.Show("Seleccione un partido.");
                return;
            }

            if (_partidoActual.Estado == "JUGADO")
            {
                MessageBox.Show("No se puede reprogramar un partido jugado.");
                return;
            }

            try
            {
                var reprog = new PartidoReprogramacion
                {
                    IdPartido = _idPartidoSeleccionado,
                    FechaAnterior = _partidoActual.Fecha,
                    FechaNueva = dtpReprogramar.Value,
                    Motivo = txtMotivoReprogramar.Text,
                    Notificado = "N"
                };

                _calendarioService.ReprogramarPartido(reprog);

                var partido = new Partido
                {
                    IdPartido = _idPartidoSeleccionado,
                    IdTorneo = _partidoActual.IdTorneo,
                    IdLocal = _partidoActual.IdLocal,
                    IdVisitante = _partidoActual.IdVisitante,
                    IdSede = _partidoActual.IdSede,
                    Fecha = dtpReprogramar.Value,
                    Jornada = _partidoActual.Jornada,
                    FormacionLocal = _partidoActual.FormacionLocal,
                    FormacionVisitante = _partidoActual.FormacionVisitante
                };

                _partidoService.ProgramarPartido(partido);
                MessageBox.Show("Reprogramación registrada.");
                CargarPartidos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al reprogramar: " + ex.Message);
            }
        }
    }
}

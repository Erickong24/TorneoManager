using System;
using System.Windows.Forms;
using TorneoManager.Logic;
using TorneoManager.Dominio;

namespace TorneoManager.Presentacion
{
    public partial class FrmGestionJugadores : Form
    {
        private GestionJugadoresService _jugadorService;
        private GestionEquiposService _equipoService;
        private GestionTorneosService _torneoService;
        private int _idJugadorSeleccionado = 0;
        private System.Data.DataTable _tablaJugadores;

        public FrmGestionJugadores()
        {
            InitializeComponent();
            _jugadorService = new GestionJugadoresService();
            _equipoService = new GestionEquiposService();
            _torneoService = new GestionTorneosService();
        }

        private void FrmGestionJugadores_Load(object sender, EventArgs e)
        {
            Tema.AplicarEstiloBoton(btnGuardar, true);
            Tema.AplicarEstiloBoton(btnNuevo, false);
            Tema.AplicarEstiloGrid(dgvJugadores);
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
                cboEquipos.DataSource = _equipoService.ListarEquipos(idTorneo);
                cboEquipos.DisplayMember = "Nombre";
                cboEquipos.ValueMember = "IdEquipo";
            }
            catch (Exception ex)
            {
                // Ignorar
            }
        }

        private void cboEquipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarJugadores();
        }

        private void CargarJugadores()
        {
            if (cboEquipos.SelectedValue == null || !(cboEquipos.SelectedValue is int)) return;

            try
            {
                int idEquipo = (int)cboEquipos.SelectedValue;
                var lista = _jugadorService.ListarJugadores(idEquipo);

                _tablaJugadores = new System.Data.DataTable();
                _tablaJugadores.Columns.Add("IdJugador", typeof(int));
                _tablaJugadores.Columns.Add("Nombre", typeof(string));
                _tablaJugadores.Columns.Add("Apellido", typeof(string));
                _tablaJugadores.Columns.Add("Posicion", typeof(string));
                _tablaJugadores.Columns.Add("Dorsal", typeof(int));
                _tablaJugadores.Columns.Add("Activo", typeof(bool));

                foreach (var j in lista)
                {
                    _tablaJugadores.Rows.Add(j.IdJugador, j.Nombre, j.Apellido, j.Posicion, j.Dorsal ?? 0, j.Activo == "S");
                }

                // Agregar filas en blanco hasta 15 (11 titulares + 4 suplentes)
                int faltantes = 15 - _tablaJugadores.Rows.Count;
                for (int i = 0; i < faltantes; i++)
                {
                    _tablaJugadores.Rows.Add(0, string.Empty, string.Empty, string.Empty, 0, true);
                }

                dgvJugadores.DataSource = _tablaJugadores;
            }
            catch (Exception ex)
            {
                // Ignorar
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cboEquipos.SelectedValue == null || !(cboEquipos.SelectedValue is int))
            {
                MessageBox.Show("Seleccione un equipo.");
                return;
            }

            int idEquipo = (int)cboEquipos.SelectedValue;
            int guardados = 0;

            try
            {
                foreach (System.Data.DataRow row in _tablaJugadores.Rows)
                {
                    string nombre = row["Nombre"]?.ToString() ?? string.Empty;
                    string apellido = row["Apellido"]?.ToString() ?? string.Empty;
                    string posicion = row["Posicion"]?.ToString() ?? string.Empty;

                    if (string.IsNullOrWhiteSpace(nombre) && string.IsNullOrWhiteSpace(apellido))
                    {
                        continue; // fila vacía
                    }

                    int idJugador = Convert.ToInt32(row["IdJugador"]);
                    int? dorsal = null;
                    if (int.TryParse(row["Dorsal"]?.ToString(), out int d)) dorsal = d;
                    bool activo = row["Activo"] != DBNull.Value && (bool)row["Activo"];

                    var jugador = new Jugador
                    {
                        IdJugador = idJugador,
                        IdEquipo = idEquipo,
                        Nombre = nombre,
                        Apellido = apellido,
                        Posicion = posicion,
                        Dorsal = dorsal,
                        Activo = activo ? "S" : "N",
                        Estado = "ACTIVO"
                    };

                    _jugadorService.GuardarJugador(jugador);
                    guardados++;
                }

                MessageBox.Show($"Se guardaron {guardados} jugadores.");
                CargarJugadores();
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
            _idJugadorSeleccionado = 0;
            if (_tablaJugadores != null)
            {
                foreach (System.Data.DataRow row in _tablaJugadores.Rows)
                {
                    row["Nombre"] = string.Empty;
                    row["Apellido"] = string.Empty;
                    row["Posicion"] = string.Empty;
                    row["Dorsal"] = 0;
                    row["Activo"] = true;
                    row["IdJugador"] = 0;
                }
            }
        }

        private void dgvJugadores_SelectionChanged(object sender, EventArgs e)
        {
            // Selección no necesaria en modo edición masiva
        }
    }
}

using System;
using System.Linq;
using System.Windows.Forms;
using TorneoManager.Logic;

namespace TorneoManager.Presentacion
{
    public partial class FrmProximosPartidos : Form
    {
        private readonly GestionTorneosService _torneoService;
        private readonly GestionPartidosService _partidoService;

        public FrmProximosPartidos()
        {
            InitializeComponent();
            _torneoService = new GestionTorneosService();
            _partidoService = new GestionPartidosService();
        }

        private void FrmProximosPartidos_Load(object sender, EventArgs e)
        {
            CargarProximos();
        }

        private void CargarProximos()
        {
            try
            {
                tabLigas.TabPages.Clear();
                var torneos = _torneoService.ListarTorneos();
                if (torneos.Count == 0)
                {
                    var emptyTab = new TabPage("Sin torneos");
                    tabLigas.TabPages.Add(emptyTab);
                    return;
                }

                foreach (var torneo in torneos)
                {
                    var partidos = _partidoService.ListarPartidos(torneo.IdTorneo)
                        .Where(p => p.Estado == "PROGRAMADO")
                        .OrderBy(p => p.Fecha ?? DateTime.MaxValue)
                        .Select(p => new
                        {
                            Liga = torneo.Nombre,
                            Fecha = p.Fecha?.ToString("yyyy-MM-dd") ?? "",
                            Hora = p.Fecha?.ToString("HH:mm") ?? "",
                            Local = p.NombreLocal,
                            Visitante = p.NombreVisitante,
                            Sede = p.NombreSede
                        })
                        .ToList();

                    var tab = new TabPage(torneo.Nombre);
                    var grid = new DataGridView
                    {
                        Dock = DockStyle.Fill,
                        ReadOnly = true,
                        AllowUserToAddRows = false,
                        AllowUserToDeleteRows = false,
                        RowHeadersVisible = false,
                        AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                    };
                    Tema.AplicarEstiloGrid(grid);
                    grid.DataSource = partidos;
                    tab.Controls.Add(grid);
                    tabLigas.TabPages.Add(tab);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar próximos partidos: " + ex.Message);
            }
        }
    }
}

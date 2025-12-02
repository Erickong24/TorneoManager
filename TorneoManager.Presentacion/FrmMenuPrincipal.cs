using System;
using System.Drawing;
using System.Windows.Forms;

namespace TorneoManager.Presentacion
{
    public partial class FrmMenuPrincipal : Form
    {
        private Button currentButton;
        private Form activeForm;

        public FrmMenuPrincipal()
        {
            InitializeComponent();
            // No usamos MDI Container standard, usamos Panel
            this.IsMdiContainer = false; 
            this.Load += FrmMenuPrincipal_Load;
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            // Abrir Próximos Partidos por defecto
            OpenChildForm(new FrmProximosPartidos(), btnProximos);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.FromArgb(0, 122, 204); // Color activo
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                    lblTituloFormulario.Text = currentButton.Text;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(30, 30, 40);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();

            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            
            // Aplicar tema al hijo
            Tema.AplicarEstiloForm(childForm);

            this.panelContenedor.Controls.Add(childForm);
            this.panelContenedor.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnTorneos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmGestionTorneos(), sender);
        }

        private void btnEquipos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmGestionEquipos(), sender);
        }

        private void btnJugadores_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmGestionJugadores(), sender);
        }

        private void btnPartidos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmFixture(), sender);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmTablaPosiciones(), sender);
        }

        private void btnProximos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmProximosPartidos(), sender);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

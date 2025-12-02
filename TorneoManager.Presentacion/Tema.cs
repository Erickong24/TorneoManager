using System.Drawing;
using System.Windows.Forms;

namespace TorneoManager.Presentacion
{
    public static class Tema
    {
        // Paleta de Colores (Modern Dark/Blue Theme)
        public static Color ColorFondoPrincipal = Color.FromArgb(240, 242, 245); // Gris muy claro
        public static Color ColorMenuLateral = Color.FromArgb(30, 30, 40); // Oscuro
        public static Color ColorPanelSuperior = Color.FromArgb(255, 255, 255); // Blanco
        
        public static Color ColorPrimario = Color.FromArgb(0, 122, 204); // Azul VS
        public static Color ColorSecundario = Color.FromArgb(255, 64, 129); // Rosa/Rojo acento
        public static Color ColorTextoPrincipal = Color.FromArgb(30, 30, 30);
        public static Color ColorTextoSecundario = Color.FromArgb(100, 100, 100);
        public static Color ColorTextoMenu = Color.FromArgb(220, 220, 220);

        // Fuentes
        public static Font FuenteTitulo = new Font("Segoe UI", 16, FontStyle.Bold);
        public static Font FuenteSubtitulo = new Font("Segoe UI", 12, FontStyle.Regular);
        public static Font FuenteNormal = new Font("Segoe UI", 10, FontStyle.Regular);
        public static Font FuenteBoton = new Font("Segoe UI", 10, FontStyle.Bold);

        public static void AplicarEstiloBoton(Button btn, bool esPrimario = true)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = FuenteBoton;
            btn.Cursor = Cursors.Hand;
            btn.Size = new Size(120, 35); // Tamaño estandar

            if (esPrimario)
            {
                btn.BackColor = ColorPrimario;
                btn.ForeColor = Color.White;
            }
            else
            {
                btn.BackColor = Color.FromArgb(200, 200, 200);
                btn.ForeColor = ColorTextoPrincipal;
            }
        }

        public static void AplicarEstiloGrid(DataGridView dgv)
        {
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            
            dgv.ColumnHeadersDefaultCellStyle.BackColor = ColorPrimario;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = ColorPrimario;
            dgv.ColumnHeadersHeight = 35;
            dgv.EnableHeadersVisualStyles = false;

            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = ColorTextoPrincipal;
            dgv.DefaultCellStyle.Font = FuenteNormal;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(200, 230, 255); // Azul claro seleccion
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgv.DefaultCellStyle.Padding = new Padding(5);
            
            dgv.RowHeadersVisible = false;
            dgv.RowTemplate.Height = 30;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public static void AplicarEstiloForm(Form frm)
        {
            frm.BackColor = ColorFondoPrincipal;
            frm.Font = FuenteNormal;
            frm.FormBorderStyle = FormBorderStyle.None; // Para forms hijos en panel
        }
    }
}

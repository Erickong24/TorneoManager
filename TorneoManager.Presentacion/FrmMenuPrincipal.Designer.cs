namespace TorneoManager.Presentacion
{
    partial class FrmMenuPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnPartidos = new System.Windows.Forms.Button();
            this.btnJugadores = new System.Windows.Forms.Button();
            this.btnEquipos = new System.Windows.Forms.Button();
            this.btnTorneos = new System.Windows.Forms.Button();
            this.btnProximos = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.lblTituloFormulario = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelBarraTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.panelMenu.Controls.Add(this.btnSalir);
            this.panelMenu.Controls.Add(this.btnReportes);
            this.panelMenu.Controls.Add(this.btnPartidos);
            this.panelMenu.Controls.Add(this.btnJugadores);
            this.panelMenu.Controls.Add(this.btnEquipos);
            this.panelMenu.Controls.Add(this.btnTorneos);
            this.panelMenu.Controls.Add(this.btnProximos);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 600);
            this.panelMenu.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSalir.Location = new System.Drawing.Point(0, 540);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSalir.Size = new System.Drawing.Size(220, 60);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReportes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReportes.Location = new System.Drawing.Point(0, 320);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnReportes.Size = new System.Drawing.Size(220, 60);
            this.btnReportes.TabIndex = 5;
            this.btnReportes.Text = "Reportes y Estadísticas";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnPartidos
            // 
            this.btnPartidos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPartidos.FlatAppearance.BorderSize = 0;
            this.btnPartidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPartidos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPartidos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPartidos.Location = new System.Drawing.Point(0, 260);
            this.btnPartidos.Name = "btnPartidos";
            this.btnPartidos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPartidos.Size = new System.Drawing.Size(220, 60);
            this.btnPartidos.TabIndex = 4;
            this.btnPartidos.Text = "Partidos (Fixture)";
            this.btnPartidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPartidos.UseVisualStyleBackColor = true;
            this.btnPartidos.Click += new System.EventHandler(this.btnPartidos_Click);
            // 
            // btnJugadores
            // 
            this.btnJugadores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnJugadores.FlatAppearance.BorderSize = 0;
            this.btnJugadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJugadores.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnJugadores.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnJugadores.Location = new System.Drawing.Point(0, 200);
            this.btnJugadores.Name = "btnJugadores";
            this.btnJugadores.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnJugadores.Size = new System.Drawing.Size(220, 60);
            this.btnJugadores.TabIndex = 3;
            this.btnJugadores.Text = "Jugadores";
            this.btnJugadores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJugadores.UseVisualStyleBackColor = true;
            this.btnJugadores.Click += new System.EventHandler(this.btnJugadores_Click);
            // 
            // btnEquipos
            // 
            this.btnEquipos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEquipos.FlatAppearance.BorderSize = 0;
            this.btnEquipos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEquipos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEquipos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEquipos.Location = new System.Drawing.Point(0, 140);
            this.btnEquipos.Name = "btnEquipos";
            this.btnEquipos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEquipos.Size = new System.Drawing.Size(220, 60);
            this.btnEquipos.TabIndex = 2;
            this.btnEquipos.Text = "Equipos";
            this.btnEquipos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEquipos.UseVisualStyleBackColor = true;
            this.btnEquipos.Click += new System.EventHandler(this.btnEquipos_Click);
            // 
            // btnTorneos
            // 
            this.btnTorneos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTorneos.FlatAppearance.BorderSize = 0;
            this.btnTorneos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTorneos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTorneos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTorneos.Location = new System.Drawing.Point(0, 140);
            this.btnTorneos.Name = "btnTorneos";
            this.btnTorneos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTorneos.Size = new System.Drawing.Size(220, 60);
            this.btnTorneos.TabIndex = 2;
            this.btnTorneos.Text = "Torneos";
            this.btnTorneos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTorneos.UseVisualStyleBackColor = true;
            this.btnTorneos.Click += new System.EventHandler(this.btnTorneos_Click);
            // 
            // btnProximos
            // 
            this.btnProximos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProximos.FlatAppearance.BorderSize = 0;
            this.btnProximos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProximos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProximos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProximos.Location = new System.Drawing.Point(0, 80);
            this.btnProximos.Name = "btnProximos";
            this.btnProximos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnProximos.Size = new System.Drawing.Size(220, 60);
            this.btnProximos.TabIndex = 1;
            this.btnProximos.Text = "Próximos partidos";
            this.btnProximos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProximos.UseVisualStyleBackColor = true;
            this.btnProximos.Click += new System.EventHandler(this.btnProximos_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.panelLogo.Controls.Add(this.lblLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(30, 28);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(155, 25);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "TorneoManager";
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(220, 60);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(780, 540);
            this.panelContenedor.TabIndex = 2;
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.White;
            this.panelBarraTitulo.Controls.Add(this.lblTituloFormulario);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(220, 0);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(780, 60);
            this.panelBarraTitulo.TabIndex = 1;
            // 
            // lblTituloFormulario
            // 
            this.lblTituloFormulario.AutoSize = true;
            this.lblTituloFormulario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloFormulario.Location = new System.Drawing.Point(20, 20);
            this.lblTituloFormulario.Name = "lblTituloFormulario";
            this.lblTituloFormulario.Size = new System.Drawing.Size(55, 21);
            this.lblTituloFormulario.TabIndex = 0;
            this.lblTituloFormulario.Text = "Inicio";
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelBarraTitulo);
            this.Controls.Add(this.panelMenu);
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TorneoManager";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelBarraTitulo.ResumeLayout(false);
            this.panelBarraTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnTorneos;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnPartidos;
        private System.Windows.Forms.Button btnJugadores;
        private System.Windows.Forms.Button btnEquipos;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.Label lblTituloFormulario;
        private System.Windows.Forms.Button btnProximos;
    }
}

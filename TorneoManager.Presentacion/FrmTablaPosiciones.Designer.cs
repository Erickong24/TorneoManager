namespace TorneoManager.Presentacion
{
    partial class FrmTablaPosiciones
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.cboTorneos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPosiciones = new System.Windows.Forms.TabPage();
            this.dgvPosiciones = new System.Windows.Forms.DataGridView();
            this.tabGoleadores = new System.Windows.Forms.TabPage();
            this.dgvGoleadores = new System.Windows.Forms.DataGridView();
            this.tabSanciones = new System.Windows.Forms.TabPage();
            this.dgvSanciones = new System.Windows.Forms.DataGridView();
            this.tabFairPlay = new System.Windows.Forms.TabPage();
            this.dgvFairPlay = new System.Windows.Forms.DataGridView();
            this.panelTop.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPosiciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosiciones)).BeginInit();
            this.tabGoleadores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoleadores)).BeginInit();
            this.tabSanciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanciones)).BeginInit();
            this.tabFairPlay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFairPlay)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Controls.Add(this.btnActualizar);
            this.panelTop.Controls.Add(this.cboTorneos);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Padding = new System.Windows.Forms.Padding(12);
            this.panelTop.Size = new System.Drawing.Size(800, 60);
            this.panelTop.TabIndex = 0;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(676, 14);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(100, 32);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // cboTorneos
            // 
            this.cboTorneos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTorneos.FormattingEnabled = true;
            this.cboTorneos.Location = new System.Drawing.Point(72, 16);
            this.cboTorneos.Name = "cboTorneos";
            this.cboTorneos.Size = new System.Drawing.Size(240, 23);
            this.cboTorneos.TabIndex = 1;
            this.cboTorneos.SelectedIndexChanged += new System.EventHandler(this.cboTorneos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Torneo:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPosiciones);
            this.tabControl1.Controls.Add(this.tabGoleadores);
            this.tabControl1.Controls.Add(this.tabSanciones);
            this.tabControl1.Controls.Add(this.tabFairPlay);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 60);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 390);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPosiciones
            // 
            this.tabPosiciones.Controls.Add(this.dgvPosiciones);
            this.tabPosiciones.Location = new System.Drawing.Point(4, 24);
            this.tabPosiciones.Name = "tabPosiciones";
            this.tabPosiciones.Padding = new System.Windows.Forms.Padding(3);
            this.tabPosiciones.Size = new System.Drawing.Size(792, 372);
            this.tabPosiciones.TabIndex = 0;
            this.tabPosiciones.Text = "Tabla de Posiciones";
            this.tabPosiciones.UseVisualStyleBackColor = true;
            // 
            // dgvPosiciones
            // 
            this.dgvPosiciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosiciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPosiciones.Location = new System.Drawing.Point(3, 3);
            this.dgvPosiciones.Name = "dgvPosiciones";
            this.dgvPosiciones.RowTemplate.Height = 25;
            this.dgvPosiciones.Size = new System.Drawing.Size(786, 366);
            this.dgvPosiciones.TabIndex = 0;
            // 
            // tabGoleadores
            // 
            this.tabGoleadores.Controls.Add(this.dgvGoleadores);
            this.tabGoleadores.Location = new System.Drawing.Point(4, 24);
            this.tabGoleadores.Name = "tabGoleadores";
            this.tabGoleadores.Padding = new System.Windows.Forms.Padding(3);
            this.tabGoleadores.Size = new System.Drawing.Size(792, 372);
            this.tabGoleadores.TabIndex = 1;
            this.tabGoleadores.Text = "Goleadores";
            this.tabGoleadores.UseVisualStyleBackColor = true;
            // 
            // dgvGoleadores
            // 
            this.dgvGoleadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGoleadores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGoleadores.Location = new System.Drawing.Point(3, 3);
            this.dgvGoleadores.Name = "dgvGoleadores";
            this.dgvGoleadores.RowTemplate.Height = 25;
            this.dgvGoleadores.Size = new System.Drawing.Size(786, 366);
            this.dgvGoleadores.TabIndex = 0;
            // 
            // tabSanciones
            // 
            this.tabSanciones.Controls.Add(this.dgvSanciones);
            this.tabSanciones.Location = new System.Drawing.Point(4, 24);
            this.tabSanciones.Name = "tabSanciones";
            this.tabSanciones.Size = new System.Drawing.Size(792, 372);
            this.tabSanciones.TabIndex = 2;
            this.tabSanciones.Text = "Sancionados";
            this.tabSanciones.UseVisualStyleBackColor = true;
            // 
            // dgvSanciones
            // 
            this.dgvSanciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSanciones.Location = new System.Drawing.Point(0, 0);
            this.dgvSanciones.Name = "dgvSanciones";
            this.dgvSanciones.RowTemplate.Height = 25;
            this.dgvSanciones.Size = new System.Drawing.Size(792, 372);
            this.dgvSanciones.TabIndex = 0;
            // 
            // tabFairPlay
            // 
            this.tabFairPlay.Controls.Add(this.dgvFairPlay);
            this.tabFairPlay.Location = new System.Drawing.Point(4, 24);
            this.tabFairPlay.Name = "tabFairPlay";
            this.tabFairPlay.Size = new System.Drawing.Size(792, 372);
            this.tabFairPlay.TabIndex = 3;
            this.tabFairPlay.Text = "Fair Play";
            this.tabFairPlay.UseVisualStyleBackColor = true;
            // 
            // dgvFairPlay
            // 
            this.dgvFairPlay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFairPlay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFairPlay.Location = new System.Drawing.Point(0, 0);
            this.dgvFairPlay.Name = "dgvFairPlay";
            this.dgvFairPlay.RowTemplate.Height = 25;
            this.dgvFairPlay.Size = new System.Drawing.Size(792, 372);
            this.dgvFairPlay.TabIndex = 0;
            // 
            // FrmTablaPosiciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panelTop);
            this.Name = "FrmTablaPosiciones";
            this.Text = "Reportes y Estadisticas";
            this.Load += new System.EventHandler(this.FrmTablaPosiciones_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPosiciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosiciones)).EndInit();
            this.tabGoleadores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoleadores)).EndInit();
            this.tabSanciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanciones)).EndInit();
            this.tabFairPlay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFairPlay)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTorneos;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPosiciones;
        private System.Windows.Forms.DataGridView dgvPosiciones;
        private System.Windows.Forms.TabPage tabGoleadores;
        private System.Windows.Forms.DataGridView dgvGoleadores;
        private System.Windows.Forms.TabPage tabSanciones;
        private System.Windows.Forms.DataGridView dgvSanciones;
        private System.Windows.Forms.TabPage tabFairPlay;
        private System.Windows.Forms.DataGridView dgvFairPlay;
    }
}

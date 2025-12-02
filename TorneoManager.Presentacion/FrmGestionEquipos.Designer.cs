namespace TorneoManager.Presentacion
{
    partial class FrmGestionEquipos
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
            this.panelControls = new System.Windows.Forms.Panel();
            this.flowButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.txtTecnico = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboTorneos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEquipos = new System.Windows.Forms.DataGridView();
            this.panelControls.SuspendLayout();
            this.flowButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControls
            // 
            this.panelControls.BackColor = System.Drawing.Color.White;
            this.panelControls.Controls.Add(this.flowButtons);
            this.panelControls.Controls.Add(this.chkActivo);
            this.panelControls.Controls.Add(this.txtTecnico);
            this.panelControls.Controls.Add(this.label4);
            this.panelControls.Controls.Add(this.txtCiudad);
            this.panelControls.Controls.Add(this.label3);
            this.panelControls.Controls.Add(this.txtNombre);
            this.panelControls.Controls.Add(this.label2);
            this.panelControls.Controls.Add(this.cboTorneos);
            this.panelControls.Controls.Add(this.label1);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControls.Location = new System.Drawing.Point(0, 0);
            this.panelControls.Name = "panelControls";
            this.panelControls.Padding = new System.Windows.Forms.Padding(16, 12, 16, 12);
            this.panelControls.Size = new System.Drawing.Size(800, 150);
            this.panelControls.TabIndex = 0;
            // 
            // flowButtons
            // 
            this.flowButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowButtons.AutoSize = true;
            this.flowButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowButtons.Controls.Add(this.btnGuardar);
            this.flowButtons.Controls.Add(this.btnNuevo);
            this.flowButtons.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.flowButtons.Location = new System.Drawing.Point(584, 16);
            this.flowButtons.Name = "flowButtons";
            this.flowButtons.Size = new System.Drawing.Size(200, 38);
            this.flowButtons.TabIndex = 12;
            this.flowButtons.WrapContents = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSize = true;
            this.btnGuardar.Location = new System.Drawing.Point(3, 3);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(92, 32);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.AutoSize = true;
            this.btnNuevo.Location = new System.Drawing.Point(106, 3);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(94, 32);
            this.btnNuevo.TabIndex = 10;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Checked = true;
            this.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActivo.Location = new System.Drawing.Point(712, 62);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(60, 19);
            this.chkActivo.TabIndex = 11;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // txtTecnico
            // 
            this.txtTecnico.Location = new System.Drawing.Point(534, 60);
            this.txtTecnico.Name = "txtTecnico";
            this.txtTecnico.Size = new System.Drawing.Size(160, 23);
            this.txtTecnico.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(474, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tecnico:";
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(304, 60);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(160, 23);
            this.txtCiudad.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ciudad:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(80, 60);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(160, 23);
            this.txtNombre.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
            // 
            // cboTorneos
            // 
            this.cboTorneos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTorneos.FormattingEnabled = true;
            this.cboTorneos.Location = new System.Drawing.Point(80, 20);
            this.cboTorneos.Name = "cboTorneos";
            this.cboTorneos.Size = new System.Drawing.Size(240, 23);
            this.cboTorneos.TabIndex = 1;
            this.cboTorneos.SelectedIndexChanged += new System.EventHandler(this.cboTorneos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Torneo:";
            // 
            // dgvEquipos
            // 
            this.dgvEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEquipos.Location = new System.Drawing.Point(0, 150);
            this.dgvEquipos.Name = "dgvEquipos";
            this.dgvEquipos.RowTemplate.Height = 25;
            this.dgvEquipos.Size = new System.Drawing.Size(800, 300);
            this.dgvEquipos.TabIndex = 1;
            this.dgvEquipos.SelectionChanged += new System.EventHandler(this.dgvEquipos_SelectionChanged);
            // 
            // FrmGestionEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvEquipos);
            this.Controls.Add(this.panelControls);
            this.Name = "FrmGestionEquipos";
            this.Text = "Gestion de Equipos";
            this.Load += new System.EventHandler(this.FrmGestionEquipos_Load);
            this.panelControls.ResumeLayout(false);
            this.panelControls.PerformLayout();
            this.flowButtons.ResumeLayout(false);
            this.flowButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipos)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTorneos;
        private System.Windows.Forms.DataGridView dgvEquipos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTecnico;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.FlowLayoutPanel flowButtons;
    }
}

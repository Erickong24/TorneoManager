namespace TorneoManager.Presentacion
{
    partial class FrmGestionJugadores
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
            this.cboEquipos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboTorneos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvJugadores = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPosicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDorsal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panelControls.SuspendLayout();
            this.flowButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugadores)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControls
            // 
            this.panelControls.BackColor = System.Drawing.Color.White;
            this.panelControls.Controls.Add(this.flowButtons);
            this.panelControls.Controls.Add(this.cboEquipos);
            this.panelControls.Controls.Add(this.label2);
            this.panelControls.Controls.Add(this.cboTorneos);
            this.panelControls.Controls.Add(this.label1);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControls.Location = new System.Drawing.Point(0, 0);
            this.panelControls.Name = "panelControls";
            this.panelControls.Padding = new System.Windows.Forms.Padding(16, 12, 16, 12);
            this.panelControls.Size = new System.Drawing.Size(900, 110);
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
            this.flowButtons.Location = new System.Drawing.Point(686, 16);
            this.flowButtons.Name = "flowButtons";
            this.flowButtons.Size = new System.Drawing.Size(200, 38);
            this.flowButtons.TabIndex = 14;
            this.flowButtons.WrapContents = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSize = true;
            this.btnGuardar.Location = new System.Drawing.Point(3, 3);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(92, 32);
            this.btnGuardar.TabIndex = 11;
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
            this.btnNuevo.TabIndex = 12;
            this.btnNuevo.Text = "Limpiar";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // cboEquipos
            // 
            this.cboEquipos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEquipos.FormattingEnabled = true;
            this.cboEquipos.Location = new System.Drawing.Point(80, 68);
            this.cboEquipos.Name = "cboEquipos";
            this.cboEquipos.Size = new System.Drawing.Size(240, 23);
            this.cboEquipos.TabIndex = 2;
            this.cboEquipos.SelectedIndexChanged += new System.EventHandler(this.cboEquipos_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Equipo:";
            // 
            // cboTorneos
            // 
            this.cboTorneos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTorneos.FormattingEnabled = true;
            this.cboTorneos.Location = new System.Drawing.Point(80, 28);
            this.cboTorneos.Name = "cboTorneos";
            this.cboTorneos.Size = new System.Drawing.Size(240, 23);
            this.cboTorneos.TabIndex = 1;
            this.cboTorneos.SelectedIndexChanged += new System.EventHandler(this.cboTorneos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Torneo:";
            // 
            // dgvJugadores
            // 
            this.dgvJugadores.AllowUserToAddRows = false;
            this.dgvJugadores.AutoGenerateColumns = false;
            this.dgvJugadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvJugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJugadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colNombre,
            this.colApellido,
            this.colPosicion,
            this.colDorsal,
            this.colActivo});
            this.dgvJugadores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvJugadores.Location = new System.Drawing.Point(0, 110);
            this.dgvJugadores.Name = "dgvJugadores";
            this.dgvJugadores.RowTemplate.Height = 25;
            this.dgvJugadores.Size = new System.Drawing.Size(900, 440);
            this.dgvJugadores.TabIndex = 1;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "IdJugador";
            this.colId.HeaderText = "IdJugador";
            this.colId.Name = "colId";
            this.colId.Visible = false;
            // 
            // colNombre
            // 
            this.colNombre.DataPropertyName = "Nombre";
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            // 
            // colApellido
            // 
            this.colApellido.DataPropertyName = "Apellido";
            this.colApellido.HeaderText = "Apellido";
            this.colApellido.Name = "colApellido";
            // 
            // colPosicion
            // 
            this.colPosicion.DataPropertyName = "Posicion";
            this.colPosicion.HeaderText = "Posicion";
            this.colPosicion.Name = "colPosicion";
            // 
            // colDorsal
            // 
            this.colDorsal.DataPropertyName = "Dorsal";
            this.colDorsal.HeaderText = "Dorsal";
            this.colDorsal.Name = "colDorsal";
            // 
            // colActivo
            // 
            this.colActivo.DataPropertyName = "Activo";
            this.colActivo.HeaderText = "Activo";
            this.colActivo.Name = "colActivo";
            // 
            // FrmGestionJugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.dgvJugadores);
            this.Controls.Add(this.panelControls);
            this.Name = "FrmGestionJugadores";
            this.Text = "Gestion de Jugadores";
            this.Load += new System.EventHandler(this.FrmGestionJugadores_Load);
            this.panelControls.ResumeLayout(false);
            this.panelControls.PerformLayout();
            this.flowButtons.ResumeLayout(false);
            this.flowButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugadores)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.FlowLayoutPanel flowButtons;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.ComboBox cboEquipos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboTorneos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvJugadores;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPosicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDorsal;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colActivo;
    }
}

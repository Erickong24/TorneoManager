namespace TorneoManager.Presentacion
{
    partial class FrmGestionTorneos
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTorneos = new System.Windows.Forms.DataGridView();
            this.panelControls.SuspendLayout();
            this.flowButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTorneos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControls
            // 
            this.panelControls.BackColor = System.Drawing.Color.White;
            this.panelControls.Controls.Add(this.flowButtons);
            this.panelControls.Controls.Add(this.chkActivo);
            this.panelControls.Controls.Add(this.dtpFechaFin);
            this.panelControls.Controls.Add(this.label3);
            this.panelControls.Controls.Add(this.dtpFechaInicio);
            this.panelControls.Controls.Add(this.label2);
            this.panelControls.Controls.Add(this.txtNombre);
            this.panelControls.Controls.Add(this.label1);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControls.Location = new System.Drawing.Point(0, 0);
            this.panelControls.Name = "panelControls";
            this.panelControls.Padding = new System.Windows.Forms.Padding(16, 12, 16, 12);
            this.panelControls.Size = new System.Drawing.Size(800, 140);
            this.panelControls.TabIndex = 0;
            // 
            // flowButtons
            // 
            this.flowButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowButtons.AutoSize = true;
            this.flowButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowButtons.Controls.Add(this.btnGuardar);
            this.flowButtons.Controls.Add(this.btnEliminar);
            this.flowButtons.Controls.Add(this.btnNuevo);
            this.flowButtons.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.flowButtons.Location = new System.Drawing.Point(486, 16);
            this.flowButtons.Name = "flowButtons";
            this.flowButtons.Size = new System.Drawing.Size(306, 38);
            this.flowButtons.TabIndex = 10;
            this.flowButtons.WrapContents = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSize = true;
            this.btnGuardar.Location = new System.Drawing.Point(3, 3);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(92, 32);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSize = true;
            this.btnEliminar.Location = new System.Drawing.Point(107, 3);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(92, 32);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.AutoSize = true;
            this.btnNuevo.Location = new System.Drawing.Point(205, 3);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(101, 32);
            this.btnNuevo.TabIndex = 9;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Checked = true;
            this.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActivo.Location = new System.Drawing.Point(392, 20);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(60, 19);
            this.chkActivo.TabIndex = 6;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(282, 56);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(100, 23);
            this.dtpFechaFin.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha Fin:";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(96, 56);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(100, 23);
            this.dtpFechaInicio.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha Inicio:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(96, 18);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(286, 23);
            this.txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // dgvTorneos
            // 
            this.dgvTorneos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTorneos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTorneos.Location = new System.Drawing.Point(0, 140);
            this.dgvTorneos.Name = "dgvTorneos";
            this.dgvTorneos.RowTemplate.Height = 25;
            this.dgvTorneos.Size = new System.Drawing.Size(800, 310);
            this.dgvTorneos.TabIndex = 1;
            this.dgvTorneos.SelectionChanged += new System.EventHandler(this.dgvTorneos_SelectionChanged);
            // 
            // FrmGestionTorneos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvTorneos);
            this.Controls.Add(this.panelControls);
            this.Name = "FrmGestionTorneos";
            this.Text = "Gestion de Torneos";
            this.Load += new System.EventHandler(this.FrmGestionTorneos_Load);
            this.panelControls.ResumeLayout(false);
            this.panelControls.PerformLayout();
            this.flowButtons.ResumeLayout(false);
            this.flowButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTorneos)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvTorneos;
        private System.Windows.Forms.FlowLayoutPanel flowButtons;
    }
}

namespace TorneoManager.Presentacion
{
    partial class FrmFixture
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
            this.cboTorneos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPartidos = new System.Windows.Forms.DataGridView();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.tableBottom = new System.Windows.Forms.TableLayoutPanel();
            this.groupProgramar = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboArbitro = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboSede = new System.Windows.Forms.ComboBox();
            this.cboFormacionVisitante = new System.Windows.Forms.ComboBox();
            this.cboFormacionLocal = new System.Windows.Forms.ComboBox();
            this.btnProgramar = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtJornada = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboVisitante = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboLocal = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupResultado = new System.Windows.Forms.GroupBox();
            this.tabAcciones = new System.Windows.Forms.TabControl();
            this.tabResultado = new System.Windows.Forms.TabPage();
            this.btnResultado = new System.Windows.Forms.Button();
            this.txtGolesVisitante = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGolesLocal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabGoles = new System.Windows.Forms.TabPage();
            this.btnGoles = new System.Windows.Forms.Button();
            this.tabTarjetas = new System.Windows.Forms.TabPage();
            this.btnTarjetas = new System.Windows.Forms.Button();
            this.tabReprogramar = new System.Windows.Forms.TabPage();
            this.btnReprogramar = new System.Windows.Forms.Button();
            this.txtMotivoReprogramar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpReprogramar = new System.Windows.Forms.DateTimePicker();
            this.labelReprog = new System.Windows.Forms.Label();
            this.lblPartidoSeleccionado = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartidos)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.tableBottom.SuspendLayout();
            this.groupProgramar.SuspendLayout();
            this.groupResultado.SuspendLayout();
            this.tabAcciones.SuspendLayout();
            this.tabResultado.SuspendLayout();
            this.tabGoles.SuspendLayout();
            this.tabTarjetas.SuspendLayout();
            this.tabReprogramar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Controls.Add(this.cboTorneos);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Padding = new System.Windows.Forms.Padding(16, 12, 16, 12);
            this.panelTop.Size = new System.Drawing.Size(1148, 56);
            this.panelTop.TabIndex = 0;
            // 
            // cboTorneos
            // 
            this.cboTorneos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTorneos.FormattingEnabled = true;
            this.cboTorneos.Location = new System.Drawing.Point(80, 16);
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
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Torneo:";
            // 
            // dgvPartidos
            // 
            this.dgvPartidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPartidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPartidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPartidos.Location = new System.Drawing.Point(0, 56);
            this.dgvPartidos.Name = "dgvPartidos";
            this.dgvPartidos.RowTemplate.Height = 25;
            this.dgvPartidos.Size = new System.Drawing.Size(1148, 338);
            this.dgvPartidos.TabIndex = 2;
            this.dgvPartidos.SelectionChanged += new System.EventHandler(this.dgvPartidos_SelectionChanged);
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.White;
            this.panelBottom.Controls.Add(this.tableBottom);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 394);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Padding = new System.Windows.Forms.Padding(12);
            this.panelBottom.Size = new System.Drawing.Size(1148, 220);
            this.panelBottom.TabIndex = 1;
            // 
            // tableBottom
            // 
            this.tableBottom.ColumnCount = 2;
            this.tableBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableBottom.Controls.Add(this.groupProgramar, 0, 0);
            this.tableBottom.Controls.Add(this.groupResultado, 1, 0);
            this.tableBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableBottom.Location = new System.Drawing.Point(12, 12);
            this.tableBottom.Name = "tableBottom";
            this.tableBottom.RowCount = 1;
            this.tableBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableBottom.Size = new System.Drawing.Size(1124, 196);
            this.tableBottom.TabIndex = 0;
            // 
            // groupProgramar
            // 
            this.groupProgramar.Controls.Add(this.label10);
            this.groupProgramar.Controls.Add(this.cboArbitro);
            this.groupProgramar.Controls.Add(this.label9);
            this.groupProgramar.Controls.Add(this.cboSede);
            this.groupProgramar.Controls.Add(this.cboFormacionVisitante);
            this.groupProgramar.Controls.Add(this.cboFormacionLocal);
            this.groupProgramar.Controls.Add(this.btnProgramar);
            this.groupProgramar.Controls.Add(this.dtpFecha);
            this.groupProgramar.Controls.Add(this.label5);
            this.groupProgramar.Controls.Add(this.txtJornada);
            this.groupProgramar.Controls.Add(this.label4);
            this.groupProgramar.Controls.Add(this.cboVisitante);
            this.groupProgramar.Controls.Add(this.label3);
            this.groupProgramar.Controls.Add(this.cboLocal);
            this.groupProgramar.Controls.Add(this.label2);
            this.groupProgramar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupProgramar.Location = new System.Drawing.Point(3, 3);
            this.groupProgramar.Name = "groupProgramar";
            this.groupProgramar.Padding = new System.Windows.Forms.Padding(10);
            this.groupProgramar.Size = new System.Drawing.Size(556, 190);
            this.groupProgramar.TabIndex = 0;
            this.groupProgramar.TabStop = false;
            this.groupProgramar.Text = "Programar Partido";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 154);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 15);
            this.label10.TabIndex = 15;
            this.label10.Text = "Arbitro:";
            // 
            // cboArbitro
            // 
            this.cboArbitro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboArbitro.FormattingEnabled = true;
            this.cboArbitro.Location = new System.Drawing.Point(80, 150);
            this.cboArbitro.Name = "cboArbitro";
            this.cboArbitro.Size = new System.Drawing.Size(200, 23);
            this.cboArbitro.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 15);
            this.label9.TabIndex = 13;
            this.label9.Text = "Sede:";
            // 
            // cboSede
            // 
            this.cboSede.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSede.FormattingEnabled = true;
            this.cboSede.Location = new System.Drawing.Point(80, 118);
            this.cboSede.Name = "cboSede";
            this.cboSede.Size = new System.Drawing.Size(200, 23);
            this.cboSede.TabIndex = 12;
            // 
            // cboFormacionVisitante
            // 
            this.cboFormacionVisitante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFormacionVisitante.FormattingEnabled = true;
            this.cboFormacionVisitante.Items.AddRange(new object[] {
            "4-4-2",
            "4-3-3",
            "3-5-2",
            "5-3-2",
            "4-2-3-1"});
            this.cboFormacionVisitante.Location = new System.Drawing.Point(362, 62);
            this.cboFormacionVisitante.Name = "cboFormacionVisitante";
            this.cboFormacionVisitante.Size = new System.Drawing.Size(90, 23);
            this.cboFormacionVisitante.TabIndex = 10;
            // 
            // cboFormacionLocal
            // 
            this.cboFormacionLocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFormacionLocal.FormattingEnabled = true;
            this.cboFormacionLocal.Items.AddRange(new object[] {
            "4-4-2",
            "4-3-3",
            "3-5-2",
            "5-3-2",
            "4-2-3-1"});
            this.cboFormacionLocal.Location = new System.Drawing.Point(362, 30);
            this.cboFormacionLocal.Name = "cboFormacionLocal";
            this.cboFormacionLocal.Size = new System.Drawing.Size(90, 23);
            this.cboFormacionLocal.TabIndex = 9;
            // 
            // btnProgramar
            // 
            this.btnProgramar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnProgramar.Location = new System.Drawing.Point(304, 150);
            this.btnProgramar.Name = "btnProgramar";
            this.btnProgramar.Size = new System.Drawing.Size(181, 32);
            this.btnProgramar.TabIndex = 8;
            this.btnProgramar.Text = "Programar / Actualizar";
            this.btnProgramar.UseVisualStyleBackColor = true;
            this.btnProgramar.Click += new System.EventHandler(this.btnProgramar_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(100, 90);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(100, 23);
            this.dtpFecha.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Fecha:";
            // 
            // txtJornada
            // 
            this.txtJornada.Location = new System.Drawing.Point(284, 90);
            this.txtJornada.Name = "txtJornada";
            this.txtJornada.Size = new System.Drawing.Size(50, 23);
            this.txtJornada.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Jornada:";
            // 
            // cboVisitante
            // 
            this.cboVisitante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVisitante.FormattingEnabled = true;
            this.cboVisitante.Location = new System.Drawing.Point(100, 60);
            this.cboVisitante.Name = "cboVisitante";
            this.cboVisitante.Size = new System.Drawing.Size(200, 23);
            this.cboVisitante.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Visitante:";
            // 
            // cboLocal
            // 
            this.cboLocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocal.FormattingEnabled = true;
            this.cboLocal.Location = new System.Drawing.Point(100, 30);
            this.cboLocal.Name = "cboLocal";
            this.cboLocal.Size = new System.Drawing.Size(200, 23);
            this.cboLocal.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Local:";
            // 
            // groupResultado
            // 
            this.groupResultado.Controls.Add(this.tabAcciones);
            this.groupResultado.Controls.Add(this.lblPartidoSeleccionado);
            this.groupResultado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupResultado.Location = new System.Drawing.Point(565, 3);
            this.groupResultado.Name = "groupResultado";
            this.groupResultado.Padding = new System.Windows.Forms.Padding(10);
            this.groupResultado.Size = new System.Drawing.Size(556, 190);
            this.groupResultado.TabIndex = 1;
            this.groupResultado.TabStop = false;
            this.groupResultado.Text = "Acciones sobre el partido";
            // 
            // tabAcciones
            // 
            this.tabAcciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tabAcciones.Controls.Add(this.tabResultado);
            this.tabAcciones.Controls.Add(this.tabGoles);
            this.tabAcciones.Controls.Add(this.tabTarjetas);
            this.tabAcciones.Controls.Add(this.tabReprogramar);
            this.tabAcciones.Location = new System.Drawing.Point(20, 52);
            this.tabAcciones.Name = "tabAcciones";
            this.tabAcciones.SelectedIndex = 0;
            this.tabAcciones.Size = new System.Drawing.Size(518, 128);
            this.tabAcciones.TabIndex = 1;
            // 
            // tabResultado
            // 
            this.tabResultado.Controls.Add(this.btnResultado);
            this.tabResultado.Controls.Add(this.txtGolesVisitante);
            this.tabResultado.Controls.Add(this.label7);
            this.tabResultado.Controls.Add(this.txtGolesLocal);
            this.tabResultado.Controls.Add(this.label6);
            this.tabResultado.Location = new System.Drawing.Point(4, 24);
            this.tabResultado.Name = "tabResultado";
            this.tabResultado.Padding = new System.Windows.Forms.Padding(8);
            this.tabResultado.Size = new System.Drawing.Size(510, 100);
            this.tabResultado.TabIndex = 0;
            this.tabResultado.Text = "Resultado";
            this.tabResultado.UseVisualStyleBackColor = true;
            // 
            // btnResultado
            // 
            this.btnResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnResultado.Location = new System.Drawing.Point(8, 62);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(140, 26);
            this.btnResultado.TabIndex = 5;
            this.btnResultado.Text = "Guardar resultado";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // txtGolesVisitante
            // 
            this.txtGolesVisitante.Location = new System.Drawing.Point(262, 20);
            this.txtGolesVisitante.Name = "txtGolesVisitante";
            this.txtGolesVisitante.Size = new System.Drawing.Size(50, 23);
            this.txtGolesVisitante.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(168, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Goles Visitante:";
            // 
            // txtGolesLocal
            // 
            this.txtGolesLocal.Location = new System.Drawing.Point(100, 20);
            this.txtGolesLocal.Name = "txtGolesLocal";
            this.txtGolesLocal.Size = new System.Drawing.Size(50, 23);
            this.txtGolesLocal.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Goles Local:";
            // 
            // tabGoles
            // 
            this.tabGoles.Controls.Add(this.btnGoles);
            this.tabGoles.Location = new System.Drawing.Point(4, 24);
            this.tabGoles.Name = "tabGoles";
            this.tabGoles.Padding = new System.Windows.Forms.Padding(8);
            this.tabGoles.Size = new System.Drawing.Size(510, 100);
            this.tabGoles.TabIndex = 1;
            this.tabGoles.Text = "Goles";
            this.tabGoles.UseVisualStyleBackColor = true;
            // 
            // btnGoles
            // 
            this.btnGoles.Location = new System.Drawing.Point(16, 18);
            this.btnGoles.Name = "btnGoles";
            this.btnGoles.Size = new System.Drawing.Size(140, 26);
            this.btnGoles.TabIndex = 0;
            this.btnGoles.Text = "Gestionar goles";
            this.btnGoles.UseVisualStyleBackColor = true;
            this.btnGoles.Click += new System.EventHandler(this.btnGoles_Click);
            // 
            // tabTarjetas
            // 
            this.tabTarjetas.Controls.Add(this.btnTarjetas);
            this.tabTarjetas.Location = new System.Drawing.Point(4, 24);
            this.tabTarjetas.Name = "tabTarjetas";
            this.tabTarjetas.Padding = new System.Windows.Forms.Padding(8);
            this.tabTarjetas.Size = new System.Drawing.Size(510, 100);
            this.tabTarjetas.TabIndex = 2;
            this.tabTarjetas.Text = "Tarjetas";
            this.tabTarjetas.UseVisualStyleBackColor = true;
            // 
            // btnTarjetas
            // 
            this.btnTarjetas.Location = new System.Drawing.Point(16, 18);
            this.btnTarjetas.Name = "btnTarjetas";
            this.btnTarjetas.Size = new System.Drawing.Size(140, 26);
            this.btnTarjetas.TabIndex = 0;
            this.btnTarjetas.Text = "Gestionar tarjetas";
            this.btnTarjetas.UseVisualStyleBackColor = true;
            this.btnTarjetas.Click += new System.EventHandler(this.btnTarjetas_Click);
            // 
            // tabReprogramar
            // 
            this.tabReprogramar.Controls.Add(this.btnReprogramar);
            this.tabReprogramar.Controls.Add(this.txtMotivoReprogramar);
            this.tabReprogramar.Controls.Add(this.label8);
            this.tabReprogramar.Controls.Add(this.dtpReprogramar);
            this.tabReprogramar.Controls.Add(this.labelReprog);
            this.tabReprogramar.Location = new System.Drawing.Point(4, 24);
            this.tabReprogramar.Name = "tabReprogramar";
            this.tabReprogramar.Padding = new System.Windows.Forms.Padding(8);
            this.tabReprogramar.Size = new System.Drawing.Size(510, 100);
            this.tabReprogramar.TabIndex = 3;
            this.tabReprogramar.Text = "Reprogramar";
            this.tabReprogramar.UseVisualStyleBackColor = true;
            // 
            // btnReprogramar
            // 
            this.btnReprogramar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReprogramar.Location = new System.Drawing.Point(8, 62);
            this.btnReprogramar.Name = "btnReprogramar";
            this.btnReprogramar.Size = new System.Drawing.Size(118, 26);
            this.btnReprogramar.TabIndex = 11;
            this.btnReprogramar.Text = "Reprogramar";
            this.btnReprogramar.UseVisualStyleBackColor = true;
            this.btnReprogramar.Click += new System.EventHandler(this.btnReprogramar_Click);
            // 
            // txtMotivoReprogramar
            // 
            this.txtMotivoReprogramar.Location = new System.Drawing.Point(64, 29);
            this.txtMotivoReprogramar.Name = "txtMotivoReprogramar";
            this.txtMotivoReprogramar.Size = new System.Drawing.Size(250, 23);
            this.txtMotivoReprogramar.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "Motivo:";
            // 
            // dtpReprogramar
            // 
            this.dtpReprogramar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReprogramar.Location = new System.Drawing.Point(341, 4);
            this.dtpReprogramar.Name = "dtpReprogramar";
            this.dtpReprogramar.Size = new System.Drawing.Size(120, 23);
            this.dtpReprogramar.TabIndex = 8;
            // 
            // labelReprog
            // 
            this.labelReprog.AutoSize = true;
            this.labelReprog.Location = new System.Drawing.Point(256, 8);
            this.labelReprog.Name = "labelReprog";
            this.labelReprog.Size = new System.Drawing.Size(76, 15);
            this.labelReprog.TabIndex = 7;
            this.labelReprog.Text = "Nueva fecha:";
            // 
            // lblPartidoSeleccionado
            // 
            this.lblPartidoSeleccionado.AutoSize = true;
            this.lblPartidoSeleccionado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPartidoSeleccionado.Location = new System.Drawing.Point(20, 28);
            this.lblPartidoSeleccionado.Name = "lblPartidoSeleccionado";
            this.lblPartidoSeleccionado.Size = new System.Drawing.Size(127, 15);
            this.lblPartidoSeleccionado.TabIndex = 0;
            this.lblPartidoSeleccionado.Text = "Seleccione un partido";
            // 
            // FrmFixture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 614);
            this.Controls.Add(this.dgvPartidos);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Name = "FrmFixture";
            this.Text = "Gestion de Partidos (Fixture)";
            this.Load += new System.EventHandler(this.FrmFixture_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartidos)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.tableBottom.ResumeLayout(false);
            this.groupProgramar.ResumeLayout(false);
            this.groupProgramar.PerformLayout();
            this.groupResultado.ResumeLayout(false);
            this.groupResultado.PerformLayout();
            this.tabAcciones.ResumeLayout(false);
            this.tabResultado.ResumeLayout(false);
            this.tabResultado.PerformLayout();
            this.tabGoles.ResumeLayout(false);
            this.tabTarjetas.ResumeLayout(false);
            this.tabReprogramar.ResumeLayout(false);
            this.tabReprogramar.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTorneos;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.DataGridView dgvPartidos;
        private System.Windows.Forms.TableLayoutPanel tableBottom;
        private System.Windows.Forms.GroupBox groupProgramar;
        private System.Windows.Forms.Button btnProgramar;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtJornada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboVisitante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboLocal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupResultado;
        private System.Windows.Forms.Label lblPartidoSeleccionado;
        private System.Windows.Forms.ComboBox cboFormacionLocal;
        private System.Windows.Forms.ComboBox cboFormacionVisitante;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboSede;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboArbitro;
        private System.Windows.Forms.TabControl tabAcciones;
        private System.Windows.Forms.TabPage tabResultado;
        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.TextBox txtGolesVisitante;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGolesLocal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabGoles;
        private System.Windows.Forms.Button btnGoles;
        private System.Windows.Forms.TabPage tabTarjetas;
        private System.Windows.Forms.Button btnTarjetas;
        private System.Windows.Forms.TabPage tabReprogramar;
        private System.Windows.Forms.Button btnReprogramar;
        private System.Windows.Forms.TextBox txtMotivoReprogramar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpReprogramar;
        private System.Windows.Forms.Label labelReprog;
    }
}

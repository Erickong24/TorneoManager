namespace TorneoManager.Presentacion
{
    partial class FrmProximosPartidos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tabLigas = new System.Windows.Forms.TabControl();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tabLigas
            // 
            this.tabLigas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabLigas.Location = new System.Drawing.Point(16, 44);
            this.tabLigas.Name = "tabLigas";
            this.tabLigas.SelectedIndex = 0;
            this.tabLigas.Size = new System.Drawing.Size(768, 400);
            this.tabLigas.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(16, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(162, 21);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Próximos Partidos";
            // 
            // FrmProximosPartidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.tabLigas);
            this.Name = "FrmProximosPartidos";
            this.Text = "Próximos Partidos";
            this.Load += new System.EventHandler(this.FrmProximosPartidos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabLigas;
        private System.Windows.Forms.Label lblTitulo;
    }
}

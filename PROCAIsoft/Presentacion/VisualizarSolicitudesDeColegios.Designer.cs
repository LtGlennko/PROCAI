namespace Presentacion
{
    partial class VisualizarSolicitudesDeColegios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.panel_superior = new System.Windows.Forms.Panel();
            this.dgvSolicitudes = new System.Windows.Forms.DataGridView();
            this.panel_superior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(154, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(496, 37);
            this.label3.TabIndex = 57;
            this.label3.Text = "Visualizar Solicitudes de Colegios";
            // 
            // panel_superior
            // 
            this.panel_superior.BackColor = System.Drawing.Color.Teal;
            this.panel_superior.Controls.Add(this.label3);
            this.panel_superior.Location = new System.Drawing.Point(-113, -14);
            this.panel_superior.Margin = new System.Windows.Forms.Padding(2);
            this.panel_superior.Name = "panel_superior";
            this.panel_superior.Size = new System.Drawing.Size(887, 93);
            this.panel_superior.TabIndex = 66;
            // 
            // dgvSolicitudes
            // 
            this.dgvSolicitudes.AllowUserToAddRows = false;
            this.dgvSolicitudes.AllowUserToDeleteRows = false;
            this.dgvSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolicitudes.Location = new System.Drawing.Point(48, 124);
            this.dgvSolicitudes.Name = "dgvSolicitudes";
            this.dgvSolicitudes.ReadOnly = true;
            this.dgvSolicitudes.Size = new System.Drawing.Size(680, 314);
            this.dgvSolicitudes.TabIndex = 67;
            // 
            // VisualizarSolicitudesDeColegios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(789, 488);
            this.Controls.Add(this.dgvSolicitudes);
            this.Controls.Add(this.panel_superior);
            this.Name = "VisualizarSolicitudesDeColegios";
            this.Text = "VisualizarSolicitudesDeColegios";
            this.panel_superior.ResumeLayout(false);
            this.panel_superior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel_superior;
        private System.Windows.Forms.DataGridView dgvSolicitudes;
    }
}
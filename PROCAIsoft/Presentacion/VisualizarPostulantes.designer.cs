using System.Drawing;

namespace Presentacion
{
    partial class frmVisualizarPostulantes
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
        private void disenio_tabla()
        {
            dgvPostulantes.RowsDefaultCellStyle.BackColor = Color.White;
            dgvPostulantes.Font = new Font("Century Gothic", 8, FontStyle.Regular);
            dgvPostulantes.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Bold);
            dgvPostulantes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvPostulantes.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dgvPostulantes.EnableHeadersVisualStyles = false;
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisualizarPostulantes));
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvPostulantes = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.panel_superior = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombresYap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colegio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlfApoderado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPostulantes)).BeginInit();
            this.panel_superior.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.White;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(760, 118);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(90, 30);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvPostulantes
            // 
            this.dgvPostulantes.AllowUserToOrderColumns = true;
            this.dgvPostulantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPostulantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DNI,
            this.nombresYap,
            this.Colegio,
            this.Grado,
            this.tlfApoderado});
            this.dgvPostulantes.Location = new System.Drawing.Point(76, 119);
            this.dgvPostulantes.Name = "dgvPostulantes";
            this.dgvPostulantes.Size = new System.Drawing.Size(670, 297);
            this.dgvPostulantes.TabIndex = 2;
            this.dgvPostulantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.White;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(760, 171);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(90, 30);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // panel_superior
            // 
            this.panel_superior.BackColor = System.Drawing.Color.Teal;
            this.panel_superior.Controls.Add(this.label3);
            this.panel_superior.Location = new System.Drawing.Point(-1, -1);
            this.panel_superior.Margin = new System.Windows.Forms.Padding(2);
            this.panel_superior.Name = "panel_superior";
            this.panel_superior.Size = new System.Drawing.Size(887, 93);
            this.panel_superior.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(64, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(348, 37);
            this.label3.TabIndex = 57;
            this.label3.Text = "Gestion de Postulantes";
            // 
            // DNI
            // 
            this.DNI.DataPropertyName = "DNI1";
            this.DNI.Frozen = true;
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            // 
            // nombresYap
            // 
            this.nombresYap.DataPropertyName = "NombresYapellidos";
            this.nombresYap.Frozen = true;
            this.nombresYap.HeaderText = "Nombres y apellidos";
            this.nombresYap.Name = "nombresYap";
            this.nombresYap.ReadOnly = true;
            this.nombresYap.Width = 200;
            // 
            // Colegio
            // 
            this.Colegio.DataPropertyName = "ColegioStr";
            this.Colegio.Frozen = true;
            this.Colegio.HeaderText = "Colegio";
            this.Colegio.Name = "Colegio";
            this.Colegio.Width = 140;
            // 
            // Grado
            // 
            this.Grado.DataPropertyName = "GradoStr";
            this.Grado.Frozen = true;
            this.Grado.HeaderText = "Grado";
            this.Grado.Name = "Grado";
            this.Grado.Width = 50;
            // 
            // tlfApoderado
            // 
            this.tlfApoderado.DataPropertyName = "TelefonoApoderado";
            this.tlfApoderado.Frozen = true;
            this.tlfApoderado.HeaderText = "Telefono Apoderado";
            this.tlfApoderado.Name = "tlfApoderado";
            this.tlfApoderado.ReadOnly = true;
            this.tlfApoderado.Width = 120;
            // 
            // frmVisualizarPostulantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(886, 478);
            this.Controls.Add(this.panel_superior);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dgvPostulantes);
            this.Controls.Add(this.btnAgregar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVisualizarPostulantes";
            this.Text = "Gestion Postulantes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPostulantes)).EndInit();
            this.panel_superior.ResumeLayout(false);
            this.panel_superior.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvPostulantes;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Panel panel_superior;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresYap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colegio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grado;
        private System.Windows.Forms.DataGridViewTextBoxColumn tlfApoderado;
    }
}
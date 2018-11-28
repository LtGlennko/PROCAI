using System.Drawing;

namespace Presentacion
{
    partial class GestionOrientadores
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
            dgvOrientadores.RowsDefaultCellStyle.BackColor = Color.White;
            dgvOrientadores.Font = new Font("Century Gothic", 8, FontStyle.Regular);
            dgvOrientadores.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Bold);
            dgvOrientadores.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvOrientadores.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dgvOrientadores.EnableHeadersVisualStyles = false;
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionOrientadores));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panel_superior = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvOrientadores = new System.Windows.Forms.DataGridView();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombresYap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colegio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_superior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrientadores)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(764, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 33);
            this.button1.TabIndex = 11;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(764, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 32);
            this.button2.TabIndex = 10;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.White;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(764, 142);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(98, 32);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // panel_superior
            // 
            this.panel_superior.BackColor = System.Drawing.Color.Teal;
            this.panel_superior.Controls.Add(this.label1);
            this.panel_superior.Location = new System.Drawing.Point(-2, -1);
            this.panel_superior.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_superior.Name = "panel_superior";
            this.panel_superior.Size = new System.Drawing.Size(929, 91);
            this.panel_superior.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 37);
            this.label1.TabIndex = 57;
            this.label1.Text = "Gestion de Orientadores";
            // 
            // dgvOrientadores
            // 
            this.dgvOrientadores.AllowUserToOrderColumns = true;
            this.dgvOrientadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrientadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DNI,
            this.nombresYap,
            this.Colegio});
            this.dgvOrientadores.Location = new System.Drawing.Point(76, 126);
            this.dgvOrientadores.Name = "dgvOrientadores";
            this.dgvOrientadores.Size = new System.Drawing.Size(553, 297);
            this.dgvOrientadores.TabIndex = 66;
            this.dgvOrientadores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPostulantes_CellContentClick);
            // 
            // DNI
            // 
            this.DNI.DataPropertyName = "DNI1";
            this.DNI.Frozen = true;
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            this.DNI.Width = 120;
            // 
            // nombresYap
            // 
            this.nombresYap.DataPropertyName = "NombresYapellidos";
            this.nombresYap.Frozen = true;
            this.nombresYap.HeaderText = "Nombres y apellidos";
            this.nombresYap.Name = "nombresYap";
            this.nombresYap.ReadOnly = true;
            this.nombresYap.Width = 230;
            // 
            // Colegio
            // 
            this.Colegio.DataPropertyName = "ColegioStr";
            this.Colegio.Frozen = true;
            this.Colegio.HeaderText = "Colegio";
            this.Colegio.Name = "Colegio";
            this.Colegio.Width = 160;
            // 
            // GestionOrientadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(886, 492);
            this.Controls.Add(this.dgvOrientadores);
            this.Controls.Add(this.panel_superior);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAgregar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "GestionOrientadores";
            this.Text = "GestionOrientadores";
            this.Load += new System.EventHandler(this.GestionOrientadores_Load);
            this.panel_superior.ResumeLayout(false);
            this.panel_superior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrientadores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel panel_superior;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvOrientadores;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresYap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colegio;
    }
}
using System.Drawing;

namespace Presentacion
{
    partial class Gestionar_permisos
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
            dvgUsuarios.RowsDefaultCellStyle.BackColor = Color.White;
            dvgUsuarios.Font = new Font("Century Gothic", 8, FontStyle.Regular);
            dvgUsuarios.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Bold);
            dvgUsuarios.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dvgUsuarios.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dvgUsuarios.EnableHeadersVisualStyles = false;
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestionar_permisos));
            this.label1 = new System.Windows.Forms.Label();
            this.dvgUsuarios = new System.Windows.Forms.DataGridView();
            this.FechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombresYapellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkJefe = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnModificar = new System.Windows.Forms.Button();
            this.panel_superior = new System.Windows.Forms.Panel();
            this.lbl_titulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgUsuarios)).BeginInit();
            this.panel_superior.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(343, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // dvgUsuarios
            // 
            this.dvgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FechaCreacion,
            this.NombresYapellidos,
            this.NombreCuenta,
            this.Cargo,
            this.chkJefe});
            this.dvgUsuarios.Location = new System.Drawing.Point(143, 154);
            this.dvgUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.dvgUsuarios.Name = "dvgUsuarios";
            this.dvgUsuarios.Size = new System.Drawing.Size(827, 400);
            this.dvgUsuarios.TabIndex = 2;
            // 
            // FechaCreacion
            // 
            this.FechaCreacion.DataPropertyName = "FechaCreacion";
            this.FechaCreacion.HeaderText = "Fecha de creacion";
            this.FechaCreacion.Name = "FechaCreacion";
            this.FechaCreacion.ReadOnly = true;
            this.FechaCreacion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // NombresYapellidos
            // 
            this.NombresYapellidos.DataPropertyName = "NombresYapellidos";
            this.NombresYapellidos.HeaderText = "Nombres y apellidos";
            this.NombresYapellidos.Name = "NombresYapellidos";
            this.NombresYapellidos.ReadOnly = true;
            this.NombresYapellidos.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NombresYapellidos.Width = 200;
            // 
            // NombreCuenta
            // 
            this.NombreCuenta.DataPropertyName = "NombreCuenta";
            this.NombreCuenta.HeaderText = "Username";
            this.NombreCuenta.Name = "NombreCuenta";
            this.NombreCuenta.ReadOnly = true;
            this.NombreCuenta.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NombreCuenta.Width = 125;
            // 
            // Cargo
            // 
            this.Cargo.DataPropertyName = "NomCargo";
            this.Cargo.HeaderText = "Cargo";
            this.Cargo.Name = "Cargo";
            this.Cargo.ReadOnly = true;
            this.Cargo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Cargo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // chkJefe
            // 
            this.chkJefe.DataPropertyName = "EsJefe";
            this.chkJefe.FalseValue = "";
            this.chkJefe.HeaderText = "Jefe";
            this.chkJefe.Name = "chkJefe";
            this.chkJefe.ReadOnly = true;
            this.chkJefe.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.chkJefe.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.chkJefe.TrueValue = "";
            this.chkJefe.Width = 50;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.White;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(999, 154);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(141, 46);
            this.btnModificar.TabIndex = 50;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // panel_superior
            // 
            this.panel_superior.BackColor = System.Drawing.Color.Teal;
            this.panel_superior.Controls.Add(this.lbl_titulo);
            this.panel_superior.Location = new System.Drawing.Point(-1, -1);
            this.panel_superior.Name = "panel_superior";
            this.panel_superior.Size = new System.Drawing.Size(1183, 112);
            this.panel_superior.TabIndex = 65;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo.Location = new System.Drawing.Point(41, 35);
            this.lbl_titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(518, 45);
            this.lbl_titulo.TabIndex = 57;
            this.lbl_titulo.Text = "Modificar Nivel de Permiso";
            // 
            // Gestionar_permisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1182, 606);
            this.Controls.Add(this.panel_superior);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dvgUsuarios);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Gestionar_permisos";
            this.Text = "Gestionar permisos";
            ((System.ComponentModel.ISupportInitialize)(this.dvgUsuarios)).EndInit();
            this.panel_superior.ResumeLayout(false);
            this.panel_superior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dvgUsuarios;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombresYapellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkJefe;
        private System.Windows.Forms.Panel panel_superior;
        private System.Windows.Forms.Label lbl_titulo;
    }
}
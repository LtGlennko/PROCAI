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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dvgUsuarios = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.FechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombresYapellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkJefe = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dvgUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
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
            this.dvgUsuarios.Location = new System.Drawing.Point(107, 108);
            this.dvgUsuarios.Name = "dvgUsuarios";
            this.dvgUsuarios.Size = new System.Drawing.Size(604, 325);
            this.dvgUsuarios.TabIndex = 2;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(730, 125);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 50;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Franklin Gothic Demi", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.Teal;
            this.labelTitulo.Location = new System.Drawing.Point(281, 51);
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(271, 28);
            this.labelTitulo.TabIndex = 51;
            this.labelTitulo.Text = "Modificar nivel de permiso";
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
            this.chkJefe.Width = 35;
            // 
            // Gestionar_permisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(845, 476);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dvgUsuarios);
            this.Controls.Add(this.label1);
            this.Name = "Gestionar_permisos";
            this.Text = "Gestionar permisos";
            ((System.ComponentModel.ISupportInitialize)(this.dvgUsuarios)).EndInit();
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
        private System.Windows.Forms.Label labelTitulo;
    }
}
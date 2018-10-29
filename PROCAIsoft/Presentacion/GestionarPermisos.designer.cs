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
            this.label2 = new System.Windows.Forms.Label();
            this.dvgUsuarios = new System.Windows.Forms.DataGridView();
            this.lblLeyenda = new System.Windows.Forms.Label();
            this.lblDescLeyenda = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombresYapellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboCargo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.chkJefe = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dvgUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(31, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modifique nivel de permiso";
            // 
            // dvgUsuarios
            // 
            this.dvgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FechaCreacion,
            this.NombresYapellidos,
            this.NombreCuenta,
            this.cboCargo,
            this.chkJefe});
            this.dvgUsuarios.Location = new System.Drawing.Point(34, 62);
            this.dvgUsuarios.Name = "dvgUsuarios";
            this.dvgUsuarios.Size = new System.Drawing.Size(580, 274);
            this.dvgUsuarios.TabIndex = 2;
            this.dvgUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgUsuarios_CellContentClick);
            this.dvgUsuarios.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dvgUsuarios_EditingControlShowing);
            // 
            // lblLeyenda
            // 
            this.lblLeyenda.AutoSize = true;
            this.lblLeyenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblLeyenda.ForeColor = System.Drawing.Color.Teal;
            this.lblLeyenda.Location = new System.Drawing.Point(601, 119);
            this.lblLeyenda.Name = "lblLeyenda";
            this.lblLeyenda.Size = new System.Drawing.Size(97, 78);
            this.lblLeyenda.TabIndex = 9;
            this.lblLeyenda.Text = "0 Alumno\r\n1 Orientador\r\n2 Guia\r\n3 Administrativo\r\n4 Ejecutivo\r\n5 Jefe";
            // 
            // lblDescLeyenda
            // 
            this.lblDescLeyenda.AutoSize = true;
            this.lblDescLeyenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblDescLeyenda.ForeColor = System.Drawing.Color.Teal;
            this.lblDescLeyenda.Location = new System.Drawing.Point(620, 86);
            this.lblDescLeyenda.Name = "lblDescLeyenda";
            this.lblDescLeyenda.Size = new System.Drawing.Size(55, 13);
            this.lblDescLeyenda.TabIndex = 10;
            this.lblDescLeyenda.Text = "Leyenda";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(59, 373);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Atras";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.bbc500b6_9f12_45e0_b75d_1df036f6c47c;
            this.pictureBox1.Location = new System.Drawing.Point(11, 360);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.NombresYapellidos.Width = 150;
            // 
            // NombreCuenta
            // 
            this.NombreCuenta.DataPropertyName = "NombreCuenta";
            this.NombreCuenta.HeaderText = "Username";
            this.NombreCuenta.Name = "NombreCuenta";
            this.NombreCuenta.ReadOnly = true;
            this.NombreCuenta.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NombreCuenta.Width = 110;
            // 
            // cboCargo
            // 
            this.cboCargo.AutoComplete = false;
            this.cboCargo.DataPropertyName = "IdCargo";
            this.cboCargo.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.cboCargo.HeaderText = "Cargo";
            this.cboCargo.Name = "cboCargo";
            this.cboCargo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // chkJefe
            // 
            this.chkJefe.DataPropertyName = "EsJefe";
            this.chkJefe.FalseValue = "";
            this.chkJefe.HeaderText = "Jefe";
            this.chkJefe.Name = "chkJefe";
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
            this.ClientSize = new System.Drawing.Size(710, 412);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblDescLeyenda);
            this.Controls.Add(this.lblLeyenda);
            this.Controls.Add(this.dvgUsuarios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Gestionar_permisos";
            this.Text = "Gestionar permisos";
            ((System.ComponentModel.ISupportInitialize)(this.dvgUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dvgUsuarios;
        private System.Windows.Forms.Label lblLeyenda;
        private System.Windows.Forms.Label lblDescLeyenda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombresYapellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCuenta;
        private System.Windows.Forms.DataGridViewComboBoxColumn cboCargo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkJefe;
    }
}
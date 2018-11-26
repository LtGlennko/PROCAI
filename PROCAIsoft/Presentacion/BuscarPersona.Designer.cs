namespace Presentacion
{
    partial class BuscarPersona
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
            this.labelAtras = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.labelSeleccionar = new System.Windows.Forms.Label();
            this.dgvPersonas = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomYap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CorreoElectronico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAtras
            // 
            this.labelAtras.AutoSize = true;
            this.labelAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAtras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelAtras.Location = new System.Drawing.Point(85, 365);
            this.labelAtras.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAtras.Name = "labelAtras";
            this.labelAtras.Size = new System.Drawing.Size(36, 13);
            this.labelAtras.TabIndex = 9;
            this.labelAtras.Text = "Atras";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(547, 346);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(77, 25);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // labelSeleccionar
            // 
            this.labelSeleccionar.AccessibleDescription = "";
            this.labelSeleccionar.AutoSize = true;
            this.labelSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.labelSeleccionar.ForeColor = System.Drawing.Color.Teal;
            this.labelSeleccionar.Location = new System.Drawing.Point(60, 37);
            this.labelSeleccionar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSeleccionar.Name = "labelSeleccionar";
            this.labelSeleccionar.Size = new System.Drawing.Size(248, 18);
            this.labelSeleccionar.TabIndex = 6;
            this.labelSeleccionar.Text = "Selecciona la persona buscada:";
            // 
            // dgvPersonas
            // 
            this.dgvPersonas.AllowUserToAddRows = false;
            this.dgvPersonas.AllowUserToDeleteRows = false;
            this.dgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DNI,
            this.NomYap,
            this.Celular,
            this.Sexo,
            this.CorreoElectronico});
            this.dgvPersonas.Location = new System.Drawing.Point(60, 82);
            this.dgvPersonas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPersonas.Name = "dgvPersonas";
            this.dgvPersonas.ReadOnly = true;
            this.dgvPersonas.RowTemplate.Height = 28;
            this.dgvPersonas.Size = new System.Drawing.Size(564, 250);
            this.dgvPersonas.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.bbc500b6_9f12_45e0_b75d_1df036f6c47c;
            this.pictureBox1.Location = new System.Drawing.Point(44, 357);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // DNI
            // 
            this.DNI.DataPropertyName = "DNI1";
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            // 
            // NomYap
            // 
            this.NomYap.DataPropertyName = "NombresYapellidos";
            this.NomYap.HeaderText = "Nombres y apellidos";
            this.NomYap.Name = "NomYap";
            this.NomYap.ReadOnly = true;
            // 
            // Celular
            // 
            this.Celular.DataPropertyName = "Celular";
            this.Celular.HeaderText = "Celular";
            this.Celular.Name = "Celular";
            this.Celular.ReadOnly = true;
            // 
            // Sexo
            // 
            this.Sexo.DataPropertyName = "Sexo";
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            // 
            // CorreoElectronico
            // 
            this.CorreoElectronico.DataPropertyName = "CorreoElectronico";
            this.CorreoElectronico.HeaderText = "Correo electrónico";
            this.CorreoElectronico.Name = "CorreoElectronico";
            this.CorreoElectronico.ReadOnly = true;
            // 
            // BuscarPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 403);
            this.Controls.Add(this.labelAtras);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.labelSeleccionar);
            this.Controls.Add(this.dgvPersonas);
            this.Name = "BuscarPersona";
            this.Text = "Búsqueda de Persona";
            this.Load += new System.EventHandler(this.BuscarPersona_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAtras;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label labelSeleccionar;
        private System.Windows.Forms.DataGridView dgvPersonas;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomYap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CorreoElectronico;
    }
}
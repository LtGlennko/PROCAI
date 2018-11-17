using System.Drawing;

namespace Presentacion
{
    partial class BuscarGrupo
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
        ///
        private void disenio_tabla()
        {
            dgvGrupos.RowsDefaultCellStyle.BackColor = Color.White;
            dgvGrupos.Font = new Font("Century Gothic", 8, FontStyle.Regular);
            dgvGrupos.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Bold);
            dgvGrupos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvGrupos.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dgvGrupos.EnableHeadersVisualStyles = false;
        }
    private void InitializeComponent()
        {
            this.dgvGrupos = new System.Windows.Forms.DataGridView();
            this.IDgrupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaProgramada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreActividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantAlumnos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelSeleccionar = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelAtras = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGrupos
            // 
            this.dgvGrupos.AllowUserToAddRows = false;
            this.dgvGrupos.AllowUserToDeleteRows = false;
            this.dgvGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrupos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDgrupo,
            this.FechaProgramada,
            this.NombreActividad,
            this.CantAlumnos});
            this.dgvGrupos.Location = new System.Drawing.Point(25, 69);
            this.dgvGrupos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvGrupos.Name = "dgvGrupos";
            this.dgvGrupos.ReadOnly = true;
            this.dgvGrupos.RowTemplate.Height = 28;
            this.dgvGrupos.Size = new System.Drawing.Size(564, 250);
            this.dgvGrupos.TabIndex = 0;
            // 
            // IDgrupo
            // 
            this.IDgrupo.DataPropertyName = "IdGrupoEncuestas1";
            this.IDgrupo.HeaderText = "ID Grupo";
            this.IDgrupo.Name = "IDgrupo";
            this.IDgrupo.ReadOnly = true;
            this.IDgrupo.Width = 50;
            // 
            // FechaProgramada
            // 
            this.FechaProgramada.DataPropertyName = "FechaProgramada";
            this.FechaProgramada.HeaderText = "Fecha Programada";
            this.FechaProgramada.Name = "FechaProgramada";
            this.FechaProgramada.ReadOnly = true;
            this.FechaProgramada.Width = 110;
            // 
            // NombreActividad
            // 
            this.NombreActividad.DataPropertyName = "TipoYnombreActividad";
            this.NombreActividad.HeaderText = "Actividad";
            this.NombreActividad.Name = "NombreActividad";
            this.NombreActividad.ReadOnly = true;
            this.NombreActividad.Width = 250;
            // 
            // CantAlumnos
            // 
            this.CantAlumnos.DataPropertyName = "CantAlumnos";
            this.CantAlumnos.HeaderText = "Nro alumnos";
            this.CantAlumnos.Name = "CantAlumnos";
            this.CantAlumnos.ReadOnly = true;
            this.CantAlumnos.Width = 80;
            // 
            // labelSeleccionar
            // 
            this.labelSeleccionar.AutoSize = true;
            this.labelSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.labelSeleccionar.ForeColor = System.Drawing.Color.Teal;
            this.labelSeleccionar.Location = new System.Drawing.Point(25, 24);
            this.labelSeleccionar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSeleccionar.Name = "labelSeleccionar";
            this.labelSeleccionar.Size = new System.Drawing.Size(348, 18);
            this.labelSeleccionar.TabIndex = 1;
            this.labelSeleccionar.Text = "Seleccionar el grupo perteneciente deseado :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(512, 333);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "Seleccionar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelAtras
            // 
            this.labelAtras.AutoSize = true;
            this.labelAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAtras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelAtras.Location = new System.Drawing.Point(50, 352);
            this.labelAtras.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAtras.Name = "labelAtras";
            this.labelAtras.Size = new System.Drawing.Size(36, 13);
            this.labelAtras.TabIndex = 4;
            this.labelAtras.Text = "Atras";
            this.labelAtras.Click += new System.EventHandler(this.labelAtras_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.bbc500b6_9f12_45e0_b75d_1df036f6c47c;
            this.pictureBox1.Location = new System.Drawing.Point(9, 344);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BuscarGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(623, 385);
            this.Controls.Add(this.labelAtras);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelSeleccionar);
            this.Controls.Add(this.dgvGrupos);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BuscarGrupo";
            this.Text = "BuscarGrupo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGrupos;
        private System.Windows.Forms.Label labelSeleccionar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDgrupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaProgramada;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreActividad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantAlumnos;
        private System.Windows.Forms.Label labelAtras;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
namespace Presentacion
{
    partial class InicioAdministrativo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioAdministrativo));
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblNombreUsu = new System.Windows.Forms.Label();
            this.pnlOpciones = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnGenerarReportes = new System.Windows.Forms.Button();
            this.btnGestionarPermisos = new System.Windows.Forms.Button();
            this.btnGestionarPostulantes = new System.Windows.Forms.Button();
            this.pnlVentanas = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.ptrDespliegue = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlTitulo.SuspendLayout();
            this.pnlOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrDespliegue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.White;
            this.pnlTitulo.Controls.Add(this.ptrDespliegue);
            this.pnlTitulo.Controls.Add(this.lblNombreUsu);
            this.pnlTitulo.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(215, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(731, 79);
            this.pnlTitulo.TabIndex = 16;
            // 
            // lblNombreUsu
            // 
            this.lblNombreUsu.AutoSize = true;
            this.lblNombreUsu.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsu.Location = new System.Drawing.Point(70, 26);
            this.lblNombreUsu.Name = "lblNombreUsu";
            this.lblNombreUsu.Size = new System.Drawing.Size(79, 22);
            this.lblNombreUsu.TabIndex = 5;
            this.lblNombreUsu.Text = "Usuario: ";
            // 
            // pnlOpciones
            // 
            this.pnlOpciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(38)))), ((int)(((byte)(92)))));
            this.pnlOpciones.Controls.Add(this.pictureBox3);
            this.pnlOpciones.Controls.Add(this.label1);
            this.pnlOpciones.Controls.Add(this.lblTitulo);
            this.pnlOpciones.Controls.Add(this.btnGenerarReportes);
            this.pnlOpciones.Controls.Add(this.btnGestionarPermisos);
            this.pnlOpciones.Controls.Add(this.pictureBox2);
            this.pnlOpciones.Controls.Add(this.btnGestionarPostulantes);
            this.pnlOpciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlOpciones.Location = new System.Drawing.Point(0, 0);
            this.pnlOpciones.Name = "pnlOpciones";
            this.pnlOpciones.Size = new System.Drawing.Size(215, 594);
            this.pnlOpciones.TabIndex = 15;
            this.pnlOpciones.MouseEnter += new System.EventHandler(this.pnlOpciones_MouseEnter);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-2, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 63);
            this.label1.TabIndex = 36;
            this.label1.Text = "P";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Bauhaus 93", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(38, 28);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(145, 39);
            this.lblTitulo.TabIndex = 37;
            this.lblTitulo.Text = "ROCAIsoft";
            // 
            // btnGenerarReportes
            // 
            this.btnGenerarReportes.FlatAppearance.BorderSize = 0;
            this.btnGenerarReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarReportes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarReportes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGenerarReportes.Location = new System.Drawing.Point(45, 213);
            this.btnGenerarReportes.Name = "btnGenerarReportes";
            this.btnGenerarReportes.Size = new System.Drawing.Size(170, 46);
            this.btnGenerarReportes.TabIndex = 28;
            this.btnGenerarReportes.Text = "Generar Reportes";
            this.btnGenerarReportes.UseVisualStyleBackColor = true;
            this.btnGenerarReportes.Click += new System.EventHandler(this.btnGenerarReportes_Click);
            this.btnGenerarReportes.DragEnter += new System.Windows.Forms.DragEventHandler(this.btnGenerarReportes_DragEnter);
            this.btnGenerarReportes.MouseEnter += new System.EventHandler(this.btnGenerarReportes_MouseEnter);
            // 
            // btnGestionarPermisos
            // 
            this.btnGestionarPermisos.FlatAppearance.BorderSize = 0;
            this.btnGestionarPermisos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionarPermisos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarPermisos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGestionarPermisos.Location = new System.Drawing.Point(44, 160);
            this.btnGestionarPermisos.Name = "btnGestionarPermisos";
            this.btnGestionarPermisos.Size = new System.Drawing.Size(170, 46);
            this.btnGestionarPermisos.TabIndex = 27;
            this.btnGestionarPermisos.Text = "Gestionar Permisos de Usuarios";
            this.btnGestionarPermisos.UseVisualStyleBackColor = true;
            this.btnGestionarPermisos.Click += new System.EventHandler(this.btnGestionarPermisos_Click);
            this.btnGestionarPermisos.MouseEnter += new System.EventHandler(this.btnGestionarPermisos_MouseEnter);
            // 
            // btnGestionarPostulantes
            // 
            this.btnGestionarPostulantes.FlatAppearance.BorderSize = 0;
            this.btnGestionarPostulantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionarPostulantes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarPostulantes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGestionarPostulantes.Location = new System.Drawing.Point(48, 107);
            this.btnGestionarPostulantes.Name = "btnGestionarPostulantes";
            this.btnGestionarPostulantes.Size = new System.Drawing.Size(167, 46);
            this.btnGestionarPostulantes.TabIndex = 15;
            this.btnGestionarPostulantes.Text = "Gestionar Datos de Postulantes";
            this.btnGestionarPostulantes.UseVisualStyleBackColor = true;
            this.btnGestionarPostulantes.Click += new System.EventHandler(this.btnGestionarPostulantes_Click);
            this.btnGestionarPostulantes.MouseEnter += new System.EventHandler(this.btnGestionarPostulantes_MouseEnter);
            // 
            // pnlVentanas
            // 
            this.pnlVentanas.Location = new System.Drawing.Point(45, 79);
            this.pnlVentanas.Name = "pnlVentanas";
            this.pnlVentanas.Size = new System.Drawing.Size(900, 515);
            this.pnlVentanas.TabIndex = 17;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.Image = global::Presentacion.Properties.Resources.logout;
            this.btnSalir.Location = new System.Drawing.Point(895, 14);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(23, 24);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSalir.TabIndex = 14;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // ptrDespliegue
            // 
            this.ptrDespliegue.Image = global::Presentacion.Properties.Resources._56763;
            this.ptrDespliegue.Location = new System.Drawing.Point(11, 12);
            this.ptrDespliegue.Name = "ptrDespliegue";
            this.ptrDespliegue.Size = new System.Drawing.Size(35, 35);
            this.ptrDespliegue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptrDespliegue.TabIndex = 7;
            this.ptrDespliegue.TabStop = false;
            this.ptrDespliegue.Click += new System.EventHandler(this.ptrDespliegue_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Presentacion.Properties.Resources._46522839_2303321959695525_7286646205050781696_n;
            this.pictureBox3.Location = new System.Drawing.Point(172, 27);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 37);
            this.pictureBox3.TabIndex = 38;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Presentacion.Properties.Resources.flecha;
            this.pictureBox2.Location = new System.Drawing.Point(12, 107);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // InicioAdministrativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(946, 594);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.pnlOpciones);
            this.Controls.Add(this.pnlVentanas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InicioAdministrativo";
            this.Text = "InicioAdministrativo";
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.pnlOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrDespliegue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.PictureBox ptrDespliegue;
        private System.Windows.Forms.Label lblNombreUsu;
        private System.Windows.Forms.Panel pnlOpciones;
        private System.Windows.Forms.Button btnGenerarReportes;
        private System.Windows.Forms.Button btnGestionarPermisos;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnGestionarPostulantes;
        private System.Windows.Forms.Panel pnlVentanas;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitulo;
    }
}
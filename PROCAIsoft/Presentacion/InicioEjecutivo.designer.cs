﻿namespace Presentacion
{
    partial class InicioEjecutivo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioEjecutivo));
            this.lblNombreUsu = new System.Windows.Forms.Label();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.ptrDespliegue = new System.Windows.Forms.PictureBox();
            this.pnlVentanas = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.btnGestionarStock = new System.Windows.Forms.Button();
            this.btnGestColegios = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnGestProcesosAdm = new System.Windows.Forms.Button();
            this.btnIncripcionAct = new System.Windows.Forms.Button();
            this.btnGestionarPermisos = new System.Windows.Forms.Button();
            this.btnGenerarReportes = new System.Windows.Forms.Button();
            this.btnGestionTA = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pnlOpciones = new System.Windows.Forms.Panel();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrDespliegue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pnlOpciones.SuspendLayout();
            this.SuspendLayout();
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
            this.pnlTitulo.TabIndex = 12;
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
            // pnlVentanas
            // 
            this.pnlVentanas.Location = new System.Drawing.Point(45, 79);
            this.pnlVentanas.Name = "pnlVentanas";
            this.pnlVentanas.Size = new System.Drawing.Size(900, 531);
            this.pnlVentanas.TabIndex = 13;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.Image = global::Presentacion.Properties.Resources.logout;
            this.btnSalir.Location = new System.Drawing.Point(895, 14);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(23, 24);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSalir.TabIndex = 6;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGestionarStock
            // 
            this.btnGestionarStock.FlatAppearance.BorderSize = 0;
            this.btnGestionarStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionarStock.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarStock.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGestionarStock.Location = new System.Drawing.Point(44, 107);
            this.btnGestionarStock.Name = "btnGestionarStock";
            this.btnGestionarStock.Size = new System.Drawing.Size(167, 46);
            this.btnGestionarStock.TabIndex = 15;
            this.btnGestionarStock.Text = "Gestionar Stock";
            this.btnGestionarStock.UseVisualStyleBackColor = true;
            this.btnGestionarStock.Click += new System.EventHandler(this.btnGestionarStock_Click);
            this.btnGestionarStock.MouseEnter += new System.EventHandler(this.btnGestionarStock_MouseEnter);
            // 
            // btnGestColegios
            // 
            this.btnGestColegios.FlatAppearance.BorderSize = 0;
            this.btnGestColegios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestColegios.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestColegios.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGestColegios.Location = new System.Drawing.Point(44, 160);
            this.btnGestColegios.Name = "btnGestColegios";
            this.btnGestColegios.Size = new System.Drawing.Size(167, 46);
            this.btnGestColegios.TabIndex = 16;
            this.btnGestColegios.Text = "Gestionar Colegios";
            this.btnGestColegios.UseVisualStyleBackColor = true;
            this.btnGestColegios.Click += new System.EventHandler(this.btnGestColegios_Click);
            this.btnGestColegios.MouseEnter += new System.EventHandler(this.btnGestColegios_MouseEnter);
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
            // btnGestProcesosAdm
            // 
            this.btnGestProcesosAdm.FlatAppearance.BorderSize = 0;
            this.btnGestProcesosAdm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestProcesosAdm.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestProcesosAdm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGestProcesosAdm.Location = new System.Drawing.Point(43, 212);
            this.btnGestProcesosAdm.Name = "btnGestProcesosAdm";
            this.btnGestProcesosAdm.Size = new System.Drawing.Size(167, 46);
            this.btnGestProcesosAdm.TabIndex = 19;
            this.btnGestProcesosAdm.Text = "Procesos de Admisión";
            this.btnGestProcesosAdm.UseVisualStyleBackColor = true;
            this.btnGestProcesosAdm.Click += new System.EventHandler(this.btnGestProcesosAdm_Click);
            this.btnGestProcesosAdm.MouseEnter += new System.EventHandler(this.btnGestProcesosAdm_MouseEnter);
            // 
            // btnIncripcionAct
            // 
            this.btnIncripcionAct.FlatAppearance.BorderSize = 0;
            this.btnIncripcionAct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncripcionAct.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncripcionAct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIncripcionAct.Location = new System.Drawing.Point(47, 264);
            this.btnIncripcionAct.Name = "btnIncripcionAct";
            this.btnIncripcionAct.Size = new System.Drawing.Size(170, 46);
            this.btnIncripcionAct.TabIndex = 20;
            this.btnIncripcionAct.Text = "Inscripcion Actividades";
            this.btnIncripcionAct.UseVisualStyleBackColor = true;
            this.btnIncripcionAct.Click += new System.EventHandler(this.btnIncripcionAct_Click);
            this.btnIncripcionAct.MouseEnter += new System.EventHandler(this.btnIncripcionAct_MouseEnter);
            // 
            // btnGestionarPermisos
            // 
            this.btnGestionarPermisos.FlatAppearance.BorderSize = 0;
            this.btnGestionarPermisos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionarPermisos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarPermisos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGestionarPermisos.Location = new System.Drawing.Point(49, 370);
            this.btnGestionarPermisos.Name = "btnGestionarPermisos";
            this.btnGestionarPermisos.Size = new System.Drawing.Size(170, 46);
            this.btnGestionarPermisos.TabIndex = 27;
            this.btnGestionarPermisos.Text = "Gestionar Permisos de Usuarios";
            this.btnGestionarPermisos.UseVisualStyleBackColor = true;
            this.btnGestionarPermisos.Click += new System.EventHandler(this.btnGestionarPermisos_Click);
            this.btnGestionarPermisos.MouseEnter += new System.EventHandler(this.btnGestionarPermisos_MouseEnter);
            // 
            // btnGenerarReportes
            // 
            this.btnGenerarReportes.FlatAppearance.BorderSize = 0;
            this.btnGenerarReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarReportes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarReportes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGenerarReportes.Location = new System.Drawing.Point(43, 423);
            this.btnGenerarReportes.Name = "btnGenerarReportes";
            this.btnGenerarReportes.Size = new System.Drawing.Size(170, 46);
            this.btnGenerarReportes.TabIndex = 28;
            this.btnGenerarReportes.Text = "Generar Reportes";
            this.btnGenerarReportes.UseVisualStyleBackColor = true;
            this.btnGenerarReportes.Click += new System.EventHandler(this.btnGenerarReportes_Click);
            this.btnGenerarReportes.MouseEnter += new System.EventHandler(this.btnGenerarReportes_MouseEnter);
            // 
            // btnGestionTA
            // 
            this.btnGestionTA.FlatAppearance.BorderSize = 0;
            this.btnGestionTA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionTA.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionTA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGestionTA.Location = new System.Drawing.Point(43, 317);
            this.btnGestionTA.Name = "btnGestionTA";
            this.btnGestionTA.Size = new System.Drawing.Size(167, 46);
            this.btnGestionTA.TabIndex = 16;
            this.btnGestionTA.Text = "Gestionar Tipo de Actividad";
            this.btnGestionTA.UseVisualStyleBackColor = true;
            this.btnGestionTA.Click += new System.EventHandler(this.btnGestionTA_Click);
            this.btnGestionTA.MouseEnter += new System.EventHandler(this.btnGestionTA_MouseEnter);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Bauhaus 93", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(39, 28);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(145, 39);
            this.lblTitulo.TabIndex = 37;
            this.lblTitulo.Text = "ROCAIsoft";
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
            // pnlOpciones
            // 
            this.pnlOpciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(38)))), ((int)(((byte)(92)))));
            this.pnlOpciones.Controls.Add(this.pictureBox3);
            this.pnlOpciones.Controls.Add(this.label1);
            this.pnlOpciones.Controls.Add(this.lblTitulo);
            this.pnlOpciones.Controls.Add(this.btnGestionTA);
            this.pnlOpciones.Controls.Add(this.btnGenerarReportes);
            this.pnlOpciones.Controls.Add(this.btnGestionarPermisos);
            this.pnlOpciones.Controls.Add(this.btnIncripcionAct);
            this.pnlOpciones.Controls.Add(this.btnGestProcesosAdm);
            this.pnlOpciones.Controls.Add(this.pictureBox2);
            this.pnlOpciones.Controls.Add(this.btnGestColegios);
            this.pnlOpciones.Controls.Add(this.btnGestionarStock);
            this.pnlOpciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlOpciones.Location = new System.Drawing.Point(0, 0);
            this.pnlOpciones.Name = "pnlOpciones";
            this.pnlOpciones.Size = new System.Drawing.Size(215, 609);
            this.pnlOpciones.TabIndex = 11;
            this.pnlOpciones.MouseEnter += new System.EventHandler(this.pnlOpciones_MouseEnter);
            // 
            // InicioEjecutivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(946, 609);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.pnlOpciones);
            this.Controls.Add(this.pnlVentanas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InicioEjecutivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InicioEjecutivo";
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrDespliegue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pnlOpciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblNombreUsu;
        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Panel pnlVentanas;
        private System.Windows.Forms.PictureBox ptrDespliegue;
        private System.Windows.Forms.Button btnGestionarStock;
        private System.Windows.Forms.Button btnGestColegios;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnGestProcesosAdm;
        private System.Windows.Forms.Button btnIncripcionAct;
        private System.Windows.Forms.Button btnGestionarPermisos;
        private System.Windows.Forms.Button btnGenerarReportes;
        private System.Windows.Forms.Button btnGestionTA;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel pnlOpciones;
    }
}
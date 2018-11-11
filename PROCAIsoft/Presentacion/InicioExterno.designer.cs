namespace Presentacion
{
    partial class InicioExterno
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.pnlOpciones = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnInformacion = new System.Windows.Forms.Button();
            this.btnSugerirColegio = new System.Windows.Forms.Button();
            this.pnlVentanas = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.PictureBox();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.ptrDespliegue = new System.Windows.Forms.PictureBox();
            this.lblNombreUsu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.pnlOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogOut)).BeginInit();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrDespliegue)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Bauhaus 93", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(37, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(180, 39);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "ROCAIsoft";
            this.lblTitulo.MouseHover += new System.EventHandler(this.lblTitulo_MouseHover);
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
            // 
            // pnlOpciones
            // 
            this.pnlOpciones.BackColor = System.Drawing.Color.Navy;
            this.pnlOpciones.Controls.Add(this.pictureBox3);
            this.pnlOpciones.Controls.Add(this.label1);
            this.pnlOpciones.Controls.Add(this.pictureBox2);
            this.pnlOpciones.Controls.Add(this.btnInformacion);
            this.pnlOpciones.Controls.Add(this.btnSugerirColegio);
            this.pnlOpciones.Controls.Add(this.lblTitulo);
            this.pnlOpciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlOpciones.Location = new System.Drawing.Point(0, 0);
            this.pnlOpciones.Name = "pnlOpciones";
            this.pnlOpciones.Size = new System.Drawing.Size(215, 594);
            this.pnlOpciones.TabIndex = 15;
            this.pnlOpciones.MouseEnter += new System.EventHandler(this.pnlOpciones_MouseEnter);
            this.pnlOpciones.MouseLeave += new System.EventHandler(this.pnlOpciones_MouseLeave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Presentacion.Properties.Resources.flecha;
            this.pictureBox3.Location = new System.Drawing.Point(12, 171);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-1, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 51);
            this.label1.TabIndex = 21;
            this.label1.Text = "P";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Presentacion.Properties.Resources.flecha;
            this.pictureBox2.Location = new System.Drawing.Point(12, 118);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // btnInformacion
            // 
            this.btnInformacion.FlatAppearance.BorderSize = 0;
            this.btnInformacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformacion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInformacion.Location = new System.Drawing.Point(48, 160);
            this.btnInformacion.Name = "btnInformacion";
            this.btnInformacion.Size = new System.Drawing.Size(167, 46);
            this.btnInformacion.TabIndex = 16;
            this.btnInformacion.Text = "Información OCAI";
            this.btnInformacion.UseVisualStyleBackColor = true;
            this.btnInformacion.Click += new System.EventHandler(this.btnInformacion_Click);
            // 
            // btnSugerirColegio
            // 
            this.btnSugerirColegio.FlatAppearance.BorderSize = 0;
            this.btnSugerirColegio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSugerirColegio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSugerirColegio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSugerirColegio.Location = new System.Drawing.Point(48, 107);
            this.btnSugerirColegio.Name = "btnSugerirColegio";
            this.btnSugerirColegio.Size = new System.Drawing.Size(167, 46);
            this.btnSugerirColegio.TabIndex = 15;
            this.btnSugerirColegio.Text = "Sugerir Colegio";
            this.btnSugerirColegio.UseVisualStyleBackColor = true;
            this.btnSugerirColegio.Click += new System.EventHandler(this.btnSugerirColegio_Click);
            // 
            // pnlVentanas
            // 
            this.pnlVentanas.Location = new System.Drawing.Point(45, 79);
            this.pnlVentanas.Name = "pnlVentanas";
            this.pnlVentanas.Size = new System.Drawing.Size(900, 515);
            this.pnlVentanas.TabIndex = 17;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.White;
            this.btnLogOut.Image = global::Presentacion.Properties.Resources.logout;
            this.btnLogOut.Location = new System.Drawing.Point(895, 14);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(23, 24);
            this.btnLogOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnLogOut.TabIndex = 18;
            this.btnLogOut.TabStop = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
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
            this.pnlTitulo.TabIndex = 19;
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
            // lblNombreUsu
            // 
            this.lblNombreUsu.AutoSize = true;
            this.lblNombreUsu.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsu.Location = new System.Drawing.Point(70, 26);
            this.lblNombreUsu.Name = "lblNombreUsu";
            this.lblNombreUsu.Size = new System.Drawing.Size(114, 22);
            this.lblNombreUsu.TabIndex = 5;
            this.lblNombreUsu.Text = "Bienvenido(a)";
            // 
            // InicioExterno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(946, 594);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pnlOpciones);
            this.Controls.Add(this.pnlVentanas);
            this.Name = "InicioExterno";
            this.Text = "InicioExterno";
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.pnlOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogOut)).EndInit();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrDespliegue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.Panel pnlOpciones;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnInformacion;
        private System.Windows.Forms.Button btnSugerirColegio;
        private System.Windows.Forms.Panel pnlVentanas;
        private System.Windows.Forms.PictureBox btnLogOut;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.PictureBox ptrDespliegue;
        private System.Windows.Forms.Label lblNombreUsu;
    }
}
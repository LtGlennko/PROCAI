namespace Presentacion
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
            this.btnCalendario = new System.Windows.Forms.Button();
            this.lblNombreUsu = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlOpciones = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnGestColegios = new System.Windows.Forms.Button();
            this.btnGestionarStock = new System.Windows.Forms.Button();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.ptrDespliegue = new System.Windows.Forms.PictureBox();
            this.pnlVentanas = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGestCalendario = new System.Windows.Forms.Button();
            this.btnGestOrientadores = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.pnlOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrDespliegue)).BeginInit();
            this.pnlVentanas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalendario
            // 
            this.btnCalendario.Location = new System.Drawing.Point(717, 294);
            this.btnCalendario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalendario.Name = "btnCalendario";
            this.btnCalendario.Size = new System.Drawing.Size(173, 28);
            this.btnCalendario.TabIndex = 4;
            this.btnCalendario.Text = "Gestionar Calendario";
            this.btnCalendario.UseVisualStyleBackColor = true;
            this.btnCalendario.Click += new System.EventHandler(this.btnCalendario_Click);
            // 
            // lblNombreUsu
            // 
            this.lblNombreUsu.AutoSize = true;
            this.lblNombreUsu.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsu.Location = new System.Drawing.Point(93, 32);
            this.lblNombreUsu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreUsu.Name = "lblNombreUsu";
            this.lblNombreUsu.Size = new System.Drawing.Size(97, 26);
            this.lblNombreUsu.TabIndex = 5;
            this.lblNombreUsu.Text = "Usuario: ";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Bauhaus 93", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 11);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(251, 50);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "PROCAIsoft";
            // 
            // pnlOpciones
            // 
            this.pnlOpciones.BackColor = System.Drawing.Color.Navy;
            this.pnlOpciones.Controls.Add(this.button9);
            this.pnlOpciones.Controls.Add(this.button8);
            this.pnlOpciones.Controls.Add(this.btnGestOrientadores);
            this.pnlOpciones.Controls.Add(this.btnGestCalendario);
            this.pnlOpciones.Controls.Add(this.pictureBox2);
            this.pnlOpciones.Controls.Add(this.btnGestColegios);
            this.pnlOpciones.Controls.Add(this.btnGestionarStock);
            this.pnlOpciones.Controls.Add(this.lblTitulo);
            this.pnlOpciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlOpciones.Location = new System.Drawing.Point(0, 0);
            this.pnlOpciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlOpciones.Name = "pnlOpciones";
            this.pnlOpciones.Size = new System.Drawing.Size(287, 731);
            this.pnlOpciones.TabIndex = 11;
            this.pnlOpciones.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlOpciones_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Presentacion.Properties.Resources.flecha;
            this.pictureBox2.Location = new System.Drawing.Point(15, 148);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnGestColegios
            // 
            this.btnGestColegios.FlatAppearance.BorderSize = 0;
            this.btnGestColegios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestColegios.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestColegios.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGestColegios.Location = new System.Drawing.Point(64, 197);
            this.btnGestColegios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGestColegios.Name = "btnGestColegios";
            this.btnGestColegios.Size = new System.Drawing.Size(223, 57);
            this.btnGestColegios.TabIndex = 16;
            this.btnGestColegios.Text = "Gestionar Colegios";
            this.btnGestColegios.UseVisualStyleBackColor = true;
            this.btnGestColegios.Click += new System.EventHandler(this.btnGestColegios_Click);
            // 
            // btnGestionarStock
            // 
            this.btnGestionarStock.FlatAppearance.BorderSize = 0;
            this.btnGestionarStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionarStock.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarStock.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGestionarStock.Location = new System.Drawing.Point(64, 132);
            this.btnGestionarStock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGestionarStock.Name = "btnGestionarStock";
            this.btnGestionarStock.Size = new System.Drawing.Size(223, 57);
            this.btnGestionarStock.TabIndex = 15;
            this.btnGestionarStock.Text = "Gestionar Stock";
            this.btnGestionarStock.UseVisualStyleBackColor = true;
            this.btnGestionarStock.Click += new System.EventHandler(this.btnGestionarStock_Click);
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.White;
            this.pnlTitulo.Controls.Add(this.ptrDespliegue);
            this.pnlTitulo.Controls.Add(this.lblNombreUsu);
            this.pnlTitulo.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(287, 0);
            this.pnlTitulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(974, 97);
            this.pnlTitulo.TabIndex = 12;
            // 
            // ptrDespliegue
            // 
            this.ptrDespliegue.Image = global::Presentacion.Properties.Resources._56763;
            this.ptrDespliegue.Location = new System.Drawing.Point(15, 15);
            this.ptrDespliegue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ptrDespliegue.Name = "ptrDespliegue";
            this.ptrDespliegue.Size = new System.Drawing.Size(47, 43);
            this.ptrDespliegue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptrDespliegue.TabIndex = 7;
            this.ptrDespliegue.TabStop = false;
            this.ptrDespliegue.Click += new System.EventHandler(this.ptrDespliegue_Click);
            // 
            // pnlVentanas
            // 
            this.pnlVentanas.Controls.Add(this.button1);
            this.pnlVentanas.Location = new System.Drawing.Point(60, 54);
            this.pnlVentanas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlVentanas.Name = "pnlVentanas";
            this.pnlVentanas.Size = new System.Drawing.Size(1200, 677);
            this.pnlVentanas.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(367, 209);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 28);
            this.button1.TabIndex = 14;
            this.button1.Text = "Gestionar Calendario";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.logout;
            this.pictureBox1.Location = new System.Drawing.Point(1193, 17);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnGestCalendario
            // 
            this.btnGestCalendario.FlatAppearance.BorderSize = 0;
            this.btnGestCalendario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestCalendario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestCalendario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGestCalendario.Location = new System.Drawing.Point(64, 262);
            this.btnGestCalendario.Margin = new System.Windows.Forms.Padding(4);
            this.btnGestCalendario.Name = "btnGestCalendario";
            this.btnGestCalendario.Size = new System.Drawing.Size(223, 57);
            this.btnGestCalendario.TabIndex = 17;
            this.btnGestCalendario.Text = "Gestionar Calendario";
            this.btnGestCalendario.UseVisualStyleBackColor = true;
            this.btnGestCalendario.Click += new System.EventHandler(this.btnGestCalendario_Click);
            // 
            // btnGestOrientadores
            // 
            this.btnGestOrientadores.FlatAppearance.BorderSize = 0;
            this.btnGestOrientadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestOrientadores.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestOrientadores.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGestOrientadores.Location = new System.Drawing.Point(64, 327);
            this.btnGestOrientadores.Margin = new System.Windows.Forms.Padding(4);
            this.btnGestOrientadores.Name = "btnGestOrientadores";
            this.btnGestOrientadores.Size = new System.Drawing.Size(223, 57);
            this.btnGestOrientadores.TabIndex = 18;
            this.btnGestOrientadores.Text = "Gestionar Orientadores";
            this.btnGestOrientadores.UseVisualStyleBackColor = true;
            this.btnGestOrientadores.Click += new System.EventHandler(this.btnGestOrientadores_Click);
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button8.Location = new System.Drawing.Point(64, 392);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(223, 57);
            this.button8.TabIndex = 19;
            this.button8.Text = "Procesos de Admisión";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button9.Location = new System.Drawing.Point(64, 457);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(227, 57);
            this.button9.TabIndex = 20;
            this.button9.Text = "Inscripcion Actividades";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // InicioEjecutivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1261, 731);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.pnlOpciones);
            this.Controls.Add(this.btnCalendario);
            this.Controls.Add(this.pnlVentanas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "InicioEjecutivo";
            this.Text = "InicioEjecutivo";
            this.Load += new System.EventHandler(this.InicioEjecutivo_Load);
            this.pnlOpciones.ResumeLayout(false);
            this.pnlOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrDespliegue)).EndInit();
            this.pnlVentanas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCalendario;
        private System.Windows.Forms.Label lblNombreUsu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlOpciones;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Panel pnlVentanas;
        private System.Windows.Forms.PictureBox ptrDespliegue;
        private System.Windows.Forms.Button btnGestionarStock;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnGestColegios;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btnGestOrientadores;
        private System.Windows.Forms.Button btnGestCalendario;
    }
}
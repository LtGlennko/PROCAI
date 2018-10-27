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
            this.btnGestionarColegios = new System.Windows.Forms.Button();
            this.btnCalendario = new System.Windows.Forms.Button();
            this.lblNombreUsu = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.pnlOpciones = new System.Windows.Forms.Panel();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.pnlVentanas = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGestionarStock = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ptrDespliegue = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlOpciones.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            this.pnlVentanas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrDespliegue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGestionarColegios
            // 
            this.btnGestionarColegios.Location = new System.Drawing.Point(659, 356);
            this.btnGestionarColegios.Name = "btnGestionarColegios";
            this.btnGestionarColegios.Size = new System.Drawing.Size(130, 23);
            this.btnGestionarColegios.TabIndex = 1;
            this.btnGestionarColegios.Text = "Gestionar Colegios";
            this.btnGestionarColegios.UseVisualStyleBackColor = true;
            this.btnGestionarColegios.Click += new System.EventHandler(this.btnGestionarColegios_Click);
            // 
            // btnCalendario
            // 
            this.btnCalendario.Location = new System.Drawing.Point(538, 239);
            this.btnCalendario.Name = "btnCalendario";
            this.btnCalendario.Size = new System.Drawing.Size(130, 23);
            this.btnCalendario.TabIndex = 4;
            this.btnCalendario.Text = "Gestionar Calendario";
            this.btnCalendario.UseVisualStyleBackColor = true;
            this.btnCalendario.Click += new System.EventHandler(this.btnCalendario_Click);
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
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Bauhaus 93", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(200, 39);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "PROCAIsoft";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(443, 356);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(153, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "Crear Proceso de Admisión";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(538, 291);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(130, 38);
            this.button6.TabIndex = 8;
            this.button6.Text = "Gestionar Orientadores";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(357, 291);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(130, 38);
            this.button7.TabIndex = 9;
            this.button7.Text = "Validar solicitudes de orientadores";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // pnlOpciones
            // 
            this.pnlOpciones.BackColor = System.Drawing.Color.Navy;
            this.pnlOpciones.Controls.Add(this.pictureBox2);
            this.pnlOpciones.Controls.Add(this.button2);
            this.pnlOpciones.Controls.Add(this.btnGestionarStock);
            this.pnlOpciones.Controls.Add(this.lblTitulo);
            this.pnlOpciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlOpciones.Location = new System.Drawing.Point(0, 0);
            this.pnlOpciones.Name = "pnlOpciones";
            this.pnlOpciones.Size = new System.Drawing.Size(200, 594);
            this.pnlOpciones.TabIndex = 11;
            this.pnlOpciones.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlOpciones_Paint);
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.White;
            this.pnlTitulo.Controls.Add(this.ptrDespliegue);
            this.pnlTitulo.Controls.Add(this.lblNombreUsu);
            this.pnlTitulo.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(200, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(746, 79);
            this.pnlTitulo.TabIndex = 12;
            // 
            // pnlVentanas
            // 
            this.pnlVentanas.Controls.Add(this.button1);
            this.pnlVentanas.Location = new System.Drawing.Point(45, 44);
            this.pnlVentanas.Name = "pnlVentanas";
            this.pnlVentanas.Size = new System.Drawing.Size(900, 550);
            this.pnlVentanas.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(275, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Gestionar Calendario";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnGestionarStock
            // 
            this.btnGestionarStock.FlatAppearance.BorderSize = 0;
            this.btnGestionarStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionarStock.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarStock.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGestionarStock.Location = new System.Drawing.Point(45, 107);
            this.btnGestionarStock.Name = "btnGestionarStock";
            this.btnGestionarStock.Size = new System.Drawing.Size(155, 46);
            this.btnGestionarStock.TabIndex = 15;
            this.btnGestionarStock.Text = "Gestionar Stock";
            this.btnGestionarStock.UseVisualStyleBackColor = true;
            this.btnGestionarStock.Click += new System.EventHandler(this.btnGestionarStock_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(45, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 46);
            this.button2.TabIndex = 16;
            this.button2.Text = "Gestionar Colegios";
            this.button2.UseVisualStyleBackColor = true;
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
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Presentacion.Properties.Resources.flecha;
            this.pictureBox2.Location = new System.Drawing.Point(11, 120);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.logout;
            this.pictureBox1.Location = new System.Drawing.Point(895, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // InicioEjecutivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(946, 594);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.pnlOpciones);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnCalendario);
            this.Controls.Add(this.btnGestionarColegios);
            this.Controls.Add(this.pnlVentanas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "InicioEjecutivo";
            this.Text = "InicioEjecutivo";
            this.Load += new System.EventHandler(this.InicioEjecutivo_Load);
            this.pnlOpciones.ResumeLayout(false);
            this.pnlOpciones.PerformLayout();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.pnlVentanas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptrDespliegue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGestionarColegios;
        private System.Windows.Forms.Button btnCalendario;
        private System.Windows.Forms.Label lblNombreUsu;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlOpciones;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Panel pnlVentanas;
        private System.Windows.Forms.PictureBox ptrDespliegue;
        private System.Windows.Forms.Button btnGestionarStock;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
    }
}
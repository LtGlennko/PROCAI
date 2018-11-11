namespace Presentacion
{
    partial class InicioGuia
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlOpciones = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSugerirColegio = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlVentanas = new System.Windows.Forms.Panel();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.ptrDespliegue = new System.Windows.Forms.PictureBox();
            this.lblNombreUsu = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.PictureBox();
            this.pnlOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrDespliegue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogOut)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlOpciones
            // 
            this.pnlOpciones.BackColor = System.Drawing.Color.Navy;
            this.pnlOpciones.Controls.Add(this.label1);
            this.pnlOpciones.Controls.Add(this.pictureBox2);
            this.pnlOpciones.Controls.Add(this.btnSugerirColegio);
            this.pnlOpciones.Controls.Add(this.lblTitulo);
            this.pnlOpciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlOpciones.Location = new System.Drawing.Point(0, 0);
            this.pnlOpciones.Name = "pnlOpciones";
            this.pnlOpciones.Size = new System.Drawing.Size(215, 594);
            this.pnlOpciones.TabIndex = 20;
            this.pnlOpciones.MouseLeave += new System.EventHandler(this.pnlOpciones_MouseLeave);
            this.pnlOpciones.MouseHover += new System.EventHandler(this.pnlOpciones_MouseHover);
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
            this.pictureBox2.MouseHover += new System.EventHandler(this.btnSugerirColegio_MouseHover);
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
            this.btnSugerirColegio.Text = "Gestionar Encuestas";
            this.btnSugerirColegio.UseVisualStyleBackColor = true;
            this.btnSugerirColegio.Click += new System.EventHandler(this.btnSugerirColegio_Click);
            this.btnSugerirColegio.MouseHover += new System.EventHandler(this.btnSugerirColegio_MouseHover);
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
            this.lblTitulo.MouseHover += new System.EventHandler(this.btnSugerirColegio_MouseHover);
            // 
            // pnlVentanas
            // 
            this.pnlVentanas.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.pnlVentanas.AutoScroll = true;
            this.pnlVentanas.Location = new System.Drawing.Point(45, 79);
            this.pnlVentanas.Name = "pnlVentanas";
            this.pnlVentanas.Size = new System.Drawing.Size(900, 515);
            this.pnlVentanas.TabIndex = 21;
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
            this.pnlTitulo.TabIndex = 22;
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
            this.lblNombreUsu.Size = new System.Drawing.Size(79, 22);
            this.lblNombreUsu.TabIndex = 5;
            this.lblNombreUsu.Text = "Usuario: ";
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.White;
            this.btnLogOut.Image = global::Presentacion.Properties.Resources.logout;
            this.btnLogOut.Location = new System.Drawing.Point(895, 14);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(23, 24);
            this.btnLogOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnLogOut.TabIndex = 23;
            this.btnLogOut.TabStop = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // InicioGuia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(946, 594);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.pnlOpciones);
            this.Controls.Add(this.pnlVentanas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InicioGuia";
            this.Text = "Inicio Guía";
            this.pnlOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrDespliegue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogOut)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlOpciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnSugerirColegio;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlVentanas;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.PictureBox ptrDespliegue;
        private System.Windows.Forms.Label lblNombreUsu;
        private System.Windows.Forms.PictureBox btnLogOut;
    }
}


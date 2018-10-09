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
            this.btnGestionarPostul = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.lblNombreUsu = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGestionarPostul
            // 
            this.btnGestionarPostul.Location = new System.Drawing.Point(89, 77);
            this.btnGestionarPostul.Name = "btnGestionarPostul";
            this.btnGestionarPostul.Size = new System.Drawing.Size(200, 23);
            this.btnGestionarPostul.TabIndex = 0;
            this.btnGestionarPostul.Text = "Gestionar datos de postulantes";
            this.btnGestionarPostul.UseVisualStyleBackColor = true;
            this.btnGestionarPostul.Click += new System.EventHandler(this.btnGestionarPostul_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(22, 130);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 1;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // lblNombreUsu
            // 
            this.lblNombreUsu.AutoSize = true;
            this.lblNombreUsu.Location = new System.Drawing.Point(21, 18);
            this.lblNombreUsu.Name = "lblNombreUsu";
            this.lblNombreUsu.Size = new System.Drawing.Size(49, 13);
            this.lblNombreUsu.TabIndex = 2;
            this.lblNombreUsu.Text = "Usuario: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.lblNombreUsu);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 45);
            this.panel1.TabIndex = 3;
            // 
            // InicioAdministrativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(370, 169);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnGestionarPostul);
            this.Controls.Add(this.panel1);
            this.Name = "InicioAdministrativo";
            this.Text = "Inicio Administrativo";
            this.Load += new System.EventHandler(this.InicioAdministrativo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGestionarPostul;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Label lblNombreUsu;
        private System.Windows.Forms.Panel panel1;
    }
}
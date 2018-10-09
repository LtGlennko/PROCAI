namespace Presentacion
{
    partial class InicioJefe
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
            this.btnGestionarPermisos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGenerarRepEncuestas = new System.Windows.Forms.Button();
            this.lblNombreUsu = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGestionarPermisos
            // 
            this.btnGestionarPermisos.Location = new System.Drawing.Point(86, 67);
            this.btnGestionarPermisos.Name = "btnGestionarPermisos";
            this.btnGestionarPermisos.Size = new System.Drawing.Size(201, 23);
            this.btnGestionarPermisos.TabIndex = 0;
            this.btnGestionarPermisos.Text = "Gestionar permisos de usuarios";
            this.btnGestionarPermisos.UseVisualStyleBackColor = true;
            this.btnGestionarPermisos.Click += new System.EventHandler(this.btnGestionarPermisos_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Atrás";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGenerarRepEncuestas
            // 
            this.btnGenerarRepEncuestas.Location = new System.Drawing.Point(86, 118);
            this.btnGenerarRepEncuestas.Name = "btnGenerarRepEncuestas";
            this.btnGenerarRepEncuestas.Size = new System.Drawing.Size(201, 23);
            this.btnGenerarRepEncuestas.TabIndex = 2;
            this.btnGenerarRepEncuestas.Text = "Generar reportes de encuestas";
            this.btnGenerarRepEncuestas.UseVisualStyleBackColor = true;
            this.btnGenerarRepEncuestas.Click += new System.EventHandler(this.btnGenerarRepEncuestas_Click);
            // 
            // lblNombreUsu
            // 
            this.lblNombreUsu.AutoSize = true;
            this.lblNombreUsu.Location = new System.Drawing.Point(12, 18);
            this.lblNombreUsu.Name = "lblNombreUsu";
            this.lblNombreUsu.Size = new System.Drawing.Size(49, 13);
            this.lblNombreUsu.TabIndex = 3;
            this.lblNombreUsu.Text = "Usuario: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.lblNombreUsu);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 45);
            this.panel1.TabIndex = 4;
            // 
            // InicioJefe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(371, 204);
            this.Controls.Add(this.btnGenerarRepEncuestas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGestionarPermisos);
            this.Controls.Add(this.panel1);
            this.Name = "InicioJefe";
            this.Text = "InicioJefe";
            this.Load += new System.EventHandler(this.InicioJefe_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGestionarPermisos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGenerarRepEncuestas;
        private System.Windows.Forms.Label lblNombreUsu;
        private System.Windows.Forms.Panel panel1;
    }
}
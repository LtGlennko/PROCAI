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
            this.btnSugerir = new System.Windows.Forms.Button();
            this.btnInformacion = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSugerir
            // 
            this.btnSugerir.Location = new System.Drawing.Point(109, 72);
            this.btnSugerir.Name = "btnSugerir";
            this.btnSugerir.Size = new System.Drawing.Size(141, 23);
            this.btnSugerir.TabIndex = 0;
            this.btnSugerir.Text = "Sugerir colegio";
            this.btnSugerir.UseVisualStyleBackColor = true;
            this.btnSugerir.Click += new System.EventHandler(this.btnSugerir_Click);
            // 
            // btnInformacion
            // 
            this.btnInformacion.Location = new System.Drawing.Point(109, 128);
            this.btnInformacion.Name = "btnInformacion";
            this.btnInformacion.Size = new System.Drawing.Size(141, 23);
            this.btnInformacion.TabIndex = 1;
            this.btnInformacion.Text = "Información de OCAI";
            this.btnInformacion.UseVisualStyleBackColor = true;
            this.btnInformacion.Click += new System.EventHandler(this.btnInformacion_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Atrás";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InicioExterno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(380, 269);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnInformacion);
            this.Controls.Add(this.btnSugerir);
            this.Name = "InicioExterno";
            this.Text = "InicioExterno";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSugerir;
        private System.Windows.Forms.Button btnInformacion;
        private System.Windows.Forms.Button button1;
    }
}
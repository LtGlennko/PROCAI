namespace Presentacion
{
    partial class GeneradorRepEncuestas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneradorRepEncuestas));
            this.btnRepEfecGuias = new System.Windows.Forms.Button();
            this.dtpIni = new System.Windows.Forms.DateTimePicker();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.panel_superior = new System.Windows.Forms.Panel();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel_superior.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRepEfecGuias
            // 
            this.btnRepEfecGuias.BackColor = System.Drawing.Color.White;
            this.btnRepEfecGuias.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepEfecGuias.Location = new System.Drawing.Point(289, 301);
            this.btnRepEfecGuias.Margin = new System.Windows.Forms.Padding(2);
            this.btnRepEfecGuias.Name = "btnRepEfecGuias";
            this.btnRepEfecGuias.Size = new System.Drawing.Size(210, 58);
            this.btnRepEfecGuias.TabIndex = 2;
            this.btnRepEfecGuias.Text = "Generar Reporte de Efectividad de Guias";
            this.btnRepEfecGuias.UseVisualStyleBackColor = false;
            this.btnRepEfecGuias.Click += new System.EventHandler(this.btnRepEfecGuias_Click);
            // 
            // dtpIni
            // 
            this.dtpIni.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpIni.Location = new System.Drawing.Point(20, 61);
            this.dtpIni.Name = "dtpIni";
            this.dtpIni.Size = new System.Drawing.Size(267, 24);
            this.dtpIni.TabIndex = 3;
            // 
            // dtpFin
            // 
            this.dtpFin.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFin.Location = new System.Drawing.Point(382, 61);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(283, 24);
            this.dtpFin.TabIndex = 4;
            // 
            // panel_superior
            // 
            this.panel_superior.BackColor = System.Drawing.Color.Teal;
            this.panel_superior.Controls.Add(this.lbl_titulo);
            this.panel_superior.Location = new System.Drawing.Point(-1, -1);
            this.panel_superior.Margin = new System.Windows.Forms.Padding(2);
            this.panel_superior.Name = "panel_superior";
            this.panel_superior.Size = new System.Drawing.Size(908, 91);
            this.panel_superior.TabIndex = 64;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo.Location = new System.Drawing.Point(31, 28);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(260, 37);
            this.lbl_titulo.TabIndex = 57;
            this.lbl_titulo.Text = "Generar Reporte";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Controls.Add(this.dtpIni);
            this.groupBox1.Controls.Add(this.dtpFin);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Teal;
            this.groupBox1.Location = new System.Drawing.Point(68, 129);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(688, 128);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rango de Fechas";
            // 
            // GeneradorRepEncuestas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(886, 478);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel_superior);
            this.Controls.Add(this.btnRepEfecGuias);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GeneradorRepEncuestas";
            this.Text = "Generar Reporte";
            this.Load += new System.EventHandler(this.GeneradorRepEncuestas_Load);
            this.panel_superior.ResumeLayout(false);
            this.panel_superior.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRepEfecGuias;
        private System.Windows.Forms.DateTimePicker dtpIni;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.Panel panel_superior;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}


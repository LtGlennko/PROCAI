namespace Presentacion
{
    partial class frmSolicitudes
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
            this.dgv_Solicitudes = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_titulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Solicitudes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Solicitudes
            // 
            this.dgv_Solicitudes.AllowUserToAddRows = false;
            this.dgv_Solicitudes.AllowUserToDeleteRows = false;
            this.dgv_Solicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Solicitudes.Location = new System.Drawing.Point(46, 94);
            this.dgv_Solicitudes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Solicitudes.Name = "dgv_Solicitudes";
            this.dgv_Solicitudes.ReadOnly = true;
            this.dgv_Solicitudes.RowTemplate.Height = 24;
            this.dgv_Solicitudes.Size = new System.Drawing.Size(1035, 363);
            this.dgv_Solicitudes.TabIndex = 0;
            this.dgv_Solicitudes.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Solicitudes_CellMouseClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button1.Location = new System.Drawing.Point(202, 475);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Validar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button2.Location = new System.Drawing.Point(831, 475);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 32);
            this.button2.TabIndex = 2;
            this.button2.Text = "Ver mas";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Franklin Gothic Demi", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.Teal;
            this.lbl_titulo.Location = new System.Drawing.Point(169, 29);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(731, 34);
            this.lbl_titulo.TabIndex = 52;
            this.lbl_titulo.Text = "SOLICITUDES DE INSCRIPCION A ACTIVIDADES SIN VALIDAR";
            // 
            // frmSolicitudes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1119, 528);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_Solicitudes);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmSolicitudes";
            this.Text = "Solicitudes";
            this.Load += new System.EventHandler(this.frmSolicitudes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Solicitudes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Solicitudes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_titulo;
    }
}
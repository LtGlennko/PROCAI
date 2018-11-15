using System.Drawing;

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
        private void disenio_tabla()
        {
            dgv_Solicitudes.RowsDefaultCellStyle.BackColor = Color.White;
            dgv_Solicitudes.Font = new Font("Century Gothic", 8, FontStyle.Regular);
            dgv_Solicitudes.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Bold);
            dgv_Solicitudes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_Solicitudes.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dgv_Solicitudes.EnableHeadersVisualStyles = false;
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
            this.btnDertalles = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Solicitudes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Solicitudes
            // 
            this.dgv_Solicitudes.AllowUserToAddRows = false;
            this.dgv_Solicitudes.AllowUserToDeleteRows = false;
            this.dgv_Solicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Solicitudes.Location = new System.Drawing.Point(129, 94);
            this.dgv_Solicitudes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Solicitudes.Name = "dgv_Solicitudes";
            this.dgv_Solicitudes.ReadOnly = true;
            this.dgv_Solicitudes.RowTemplate.Height = 24;
            this.dgv_Solicitudes.Size = new System.Drawing.Size(903, 423);
            this.dgv_Solicitudes.TabIndex = 0;
            this.dgv_Solicitudes.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Solicitudes_CellMouseClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button1.Location = new System.Drawing.Point(1055, 94);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Validar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDertalles
            // 
            this.btnDertalles.BackColor = System.Drawing.Color.White;
            this.btnDertalles.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnDertalles.Location = new System.Drawing.Point(1055, 167);
            this.btnDertalles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDertalles.Name = "btnDertalles";
            this.btnDertalles.Size = new System.Drawing.Size(96, 32);
            this.btnDertalles.TabIndex = 55;
            this.btnDertalles.Text = "Detalles...";
            this.btnDertalles.UseVisualStyleBackColor = false;
            this.btnDertalles.Click += new System.EventHandler(this.btnDertalles_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Heavy", 16F);
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(235, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(682, 34);
            this.label1.TabIndex = 59;
            this.label1.Text = "Solicitudes de Inscripcion Actividades para Colegios";
            // 
            // frmSolicitudes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1182, 587);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDertalles);
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
        private System.Windows.Forms.Button btnDertalles;
        private System.Windows.Forms.Label label1;
    }
}
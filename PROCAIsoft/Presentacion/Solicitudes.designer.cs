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
            this.btn_validar = new System.Windows.Forms.Button();
            this.btn_detalles = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_rechazar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Solicitudes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Solicitudes
            // 
            this.dgv_Solicitudes.AllowUserToAddRows = false;
            this.dgv_Solicitudes.AllowUserToDeleteRows = false;
            this.dgv_Solicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Solicitudes.Location = new System.Drawing.Point(49, 76);
            this.dgv_Solicitudes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_Solicitudes.Name = "dgv_Solicitudes";
            this.dgv_Solicitudes.ReadOnly = true;
            this.dgv_Solicitudes.RowTemplate.Height = 24;
            this.dgv_Solicitudes.Size = new System.Drawing.Size(810, 390);
            this.dgv_Solicitudes.TabIndex = 0;
            this.dgv_Solicitudes.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Solicitudes_CellMouseClick);
            // 
            // btn_validar
            // 
            this.btn_validar.BackColor = System.Drawing.Color.White;
            this.btn_validar.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btn_validar.Location = new System.Drawing.Point(891, 89);
            this.btn_validar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_validar.Name = "btn_validar";
            this.btn_validar.Size = new System.Drawing.Size(72, 26);
            this.btn_validar.TabIndex = 1;
            this.btn_validar.Text = "Validar";
            this.btn_validar.UseVisualStyleBackColor = false;
            this.btn_validar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_detalles
            // 
            this.btn_detalles.BackColor = System.Drawing.Color.White;
            this.btn_detalles.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btn_detalles.Location = new System.Drawing.Point(891, 218);
            this.btn_detalles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_detalles.Name = "btn_detalles";
            this.btn_detalles.Size = new System.Drawing.Size(76, 26);
            this.btn_detalles.TabIndex = 55;
            this.btn_detalles.Text = "Detalles...";
            this.btn_detalles.UseVisualStyleBackColor = false;
            this.btn_detalles.Click += new System.EventHandler(this.btnDertalles_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Heavy", 16F);
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(176, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(563, 28);
            this.label1.TabIndex = 59;
            this.label1.Text = "Solicitudes de Inscripcion Actividades para Colegios";
            // 
            // btn_rechazar
            // 
            this.btn_rechazar.BackColor = System.Drawing.Color.White;
            this.btn_rechazar.Location = new System.Drawing.Point(891, 156);
            this.btn_rechazar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_rechazar.Name = "btn_rechazar";
            this.btn_rechazar.Size = new System.Drawing.Size(76, 26);
            this.btn_rechazar.TabIndex = 60;
            this.btn_rechazar.Text = "Rechazar";
            this.btn_rechazar.UseVisualStyleBackColor = false;
            this.btn_rechazar.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmSolicitudes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1001, 569);
            this.Controls.Add(this.btn_rechazar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_detalles);
            this.Controls.Add(this.btn_validar);
            this.Controls.Add(this.dgv_Solicitudes);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmSolicitudes";
            this.Text = "Solicitudes";
            this.Load += new System.EventHandler(this.frmSolicitudes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Solicitudes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Solicitudes;
        private System.Windows.Forms.Button btn_validar;
        private System.Windows.Forms.Button btn_detalles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_rechazar;
    }
}
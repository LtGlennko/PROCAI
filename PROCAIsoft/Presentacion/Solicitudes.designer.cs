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
            this.btn_rechazar = new System.Windows.Forms.Button();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.panel_superior = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbRUC = new System.Windows.Forms.RadioButton();
            this.rbNombre = new System.Windows.Forms.RadioButton();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Solicitudes)).BeginInit();
            this.panel_superior.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Solicitudes
            // 
            this.dgv_Solicitudes.AllowUserToAddRows = false;
            this.dgv_Solicitudes.AllowUserToDeleteRows = false;
            this.dgv_Solicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Solicitudes.Location = new System.Drawing.Point(79, 196);
            this.dgv_Solicitudes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Solicitudes.Name = "dgv_Solicitudes";
            this.dgv_Solicitudes.ReadOnly = true;
            this.dgv_Solicitudes.RowTemplate.Height = 24;
            this.dgv_Solicitudes.Size = new System.Drawing.Size(909, 384);
            this.dgv_Solicitudes.TabIndex = 0;
            this.dgv_Solicitudes.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Solicitudes_CellMouseClick);
            // 
            // btn_validar
            // 
            this.btn_validar.BackColor = System.Drawing.Color.White;
            this.btn_validar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_validar.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btn_validar.Location = new System.Drawing.Point(1009, 195);
            this.btn_validar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_validar.Name = "btn_validar";
            this.btn_validar.Size = new System.Drawing.Size(131, 45);
            this.btn_validar.TabIndex = 1;
            this.btn_validar.Text = "Validar";
            this.btn_validar.UseVisualStyleBackColor = false;
            this.btn_validar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_detalles
            // 
            this.btn_detalles.BackColor = System.Drawing.Color.White;
            this.btn_detalles.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_detalles.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btn_detalles.Location = new System.Drawing.Point(1009, 337);
            this.btn_detalles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_detalles.Name = "btn_detalles";
            this.btn_detalles.Size = new System.Drawing.Size(136, 45);
            this.btn_detalles.TabIndex = 55;
            this.btn_detalles.Text = "Detalles...";
            this.btn_detalles.UseVisualStyleBackColor = false;
            this.btn_detalles.Click += new System.EventHandler(this.btnDertalles_Click);
            // 
            // btn_rechazar
            // 
            this.btn_rechazar.BackColor = System.Drawing.Color.White;
            this.btn_rechazar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rechazar.Location = new System.Drawing.Point(1009, 264);
            this.btn_rechazar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_rechazar.Name = "btn_rechazar";
            this.btn_rechazar.Size = new System.Drawing.Size(136, 45);
            this.btn_rechazar.TabIndex = 60;
            this.btn_rechazar.Text = "Rechazar";
            this.btn_rechazar.UseVisualStyleBackColor = false;
            this.btn_rechazar.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo.Location = new System.Drawing.Point(85, 36);
            this.lbl_titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(769, 45);
            this.lbl_titulo.TabIndex = 57;
            this.lbl_titulo.Text = "Inscripcion a Actividades para Colegios";
            // 
            // panel_superior
            // 
            this.panel_superior.BackColor = System.Drawing.Color.Teal;
            this.panel_superior.Controls.Add(this.lbl_titulo);
            this.panel_superior.Location = new System.Drawing.Point(1, 0);
            this.panel_superior.Name = "panel_superior";
            this.panel_superior.Size = new System.Drawing.Size(1271, 114);
            this.panel_superior.TabIndex = 61;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbRUC);
            this.groupBox1.Controls.Add(this.rbNombre);
            this.groupBox1.Controls.Add(this.rbCodigo);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Teal;
            this.groupBox1.Location = new System.Drawing.Point(79, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 58);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "filtro";
            // 
            // rbRUC
            // 
            this.rbRUC.AutoSize = true;
            this.rbRUC.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRUC.Location = new System.Drawing.Point(299, 27);
            this.rbRUC.Margin = new System.Windows.Forms.Padding(4);
            this.rbRUC.Name = "rbRUC";
            this.rbRUC.Size = new System.Drawing.Size(83, 25);
            this.rbRUC.TabIndex = 68;
            this.rbRUC.TabStop = true;
            this.rbRUC.Text = "Fecha";
            this.rbRUC.UseVisualStyleBackColor = true;
            // 
            // rbNombre
            // 
            this.rbNombre.AutoSize = true;
            this.rbNombre.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNombre.Location = new System.Drawing.Point(140, 27);
            this.rbNombre.Margin = new System.Windows.Forms.Padding(4);
            this.rbNombre.Name = "rbNombre";
            this.rbNombre.Size = new System.Drawing.Size(115, 25);
            this.rbNombre.TabIndex = 67;
            this.rbNombre.TabStop = true;
            this.rbNombre.Text = "Actividad";
            this.rbNombre.UseVisualStyleBackColor = true;
            // 
            // rbCodigo
            // 
            this.rbCodigo.AutoSize = true;
            this.rbCodigo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCodigo.Location = new System.Drawing.Point(10, 27);
            this.rbCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.rbCodigo.Name = "rbCodigo";
            this.rbCodigo.Size = new System.Drawing.Size(101, 25);
            this.rbCodigo.TabIndex = 66;
            this.rbCodigo.TabStop = true;
            this.rbCodigo.Text = "Historico";
            this.rbCodigo.UseVisualStyleBackColor = true;
            // 
            // frmSolicitudes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1182, 606);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel_superior);
            this.Controls.Add(this.btn_rechazar);
            this.Controls.Add(this.btn_detalles);
            this.Controls.Add(this.btn_validar);
            this.Controls.Add(this.dgv_Solicitudes);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmSolicitudes";
            this.Text = "Solicitudes";
            this.Load += new System.EventHandler(this.frmSolicitudes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Solicitudes)).EndInit();
            this.panel_superior.ResumeLayout(false);
            this.panel_superior.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Solicitudes;
        private System.Windows.Forms.Button btn_validar;
        private System.Windows.Forms.Button btn_detalles;
        private System.Windows.Forms.Button btn_rechazar;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Panel panel_superior;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbRUC;
        private System.Windows.Forms.RadioButton rbNombre;
        private System.Windows.Forms.RadioButton rbCodigo;
    }
}
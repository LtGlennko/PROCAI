namespace Presentacion
{
    partial class VentanaNuevoProcesoAdmision
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
            this.BtnDescripcion = new System.Windows.Forms.Label();
            this.BtnVacantes = new System.Windows.Forms.Label();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_Vacantes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbx_tipoProceso = new System.Windows.Forms.ComboBox();
            this.lbl_prueba = new System.Windows.Forms.Label();
            this.rbtn_1 = new System.Windows.Forms.RadioButton();
            this.rbtn_2 = new System.Windows.Forms.RadioButton();
            this.gbx_ciclo = new System.Windows.Forms.GroupBox();
            this.datetp_fecha = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbx_ciclo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnDescripcion
            // 
            this.BtnDescripcion.AutoSize = true;
            this.BtnDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.BtnDescripcion.ForeColor = System.Drawing.Color.Teal;
            this.BtnDescripcion.Location = new System.Drawing.Point(60, 371);
            this.BtnDescripcion.Name = "BtnDescripcion";
            this.BtnDescripcion.Size = new System.Drawing.Size(155, 17);
            this.BtnDescripcion.TabIndex = 0;
            this.BtnDescripcion.Text = "Nombre del Proceso";
            // 
            // BtnVacantes
            // 
            this.BtnVacantes.AutoSize = true;
            this.BtnVacantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.BtnVacantes.ForeColor = System.Drawing.Color.Teal;
            this.BtnVacantes.Location = new System.Drawing.Point(60, 316);
            this.BtnVacantes.Name = "BtnVacantes";
            this.BtnVacantes.Size = new System.Drawing.Size(75, 17);
            this.BtnVacantes.TabIndex = 1;
            this.BtnVacantes.Text = "Vacantes";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lbl_fecha.ForeColor = System.Drawing.Color.Teal;
            this.lbl_fecha.Location = new System.Drawing.Point(60, 193);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(52, 17);
            this.lbl_fecha.TabIndex = 2;
            this.lbl_fecha.Text = "Fecha";
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Location = new System.Drawing.Point(126, 458);
            this.BtnRegistrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(89, 34);
            this.BtnRegistrar.TabIndex = 4;
            this.BtnRegistrar.Text = "Registar";
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            this.BtnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(290, 458);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(91, 34);
            this.BtnCancel.TabIndex = 5;
            this.BtnCancel.Text = "Cancelar";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(227, 371);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.ReadOnly = true;
            this.txt_nombre.Size = new System.Drawing.Size(235, 22);
            this.txt_nombre.TabIndex = 6;
            // 
            // txt_Vacantes
            // 
            this.txt_Vacantes.Location = new System.Drawing.Point(227, 311);
            this.txt_Vacantes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Vacantes.Name = "txt_Vacantes";
            this.txt_Vacantes.Size = new System.Drawing.Size(54, 22);
            this.txt_Vacantes.TabIndex = 7;
            this.txt_Vacantes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Vacantes_KeyPress);
            this.txt_Vacantes.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Vacantes_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(60, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tipo de Proceso:";
            // 
            // cmbx_tipoProceso
            // 
            this.cmbx_tipoProceso.FormattingEnabled = true;
            this.cmbx_tipoProceso.Location = new System.Drawing.Point(227, 139);
            this.cmbx_tipoProceso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbx_tipoProceso.Name = "cmbx_tipoProceso";
            this.cmbx_tipoProceso.Size = new System.Drawing.Size(160, 24);
            this.cmbx_tipoProceso.TabIndex = 15;
            this.cmbx_tipoProceso.SelectedValueChanged += new System.EventHandler(this.cmbx_tipoProceso_SelectedValueChanged);
            // 
            // lbl_prueba
            // 
            this.lbl_prueba.AutoSize = true;
            this.lbl_prueba.Location = new System.Drawing.Point(287, 314);
            this.lbl_prueba.Name = "lbl_prueba";
            this.lbl_prueba.Size = new System.Drawing.Size(0, 17);
            this.lbl_prueba.TabIndex = 17;
            // 
            // rbtn_1
            // 
            this.rbtn_1.AutoSize = true;
            this.rbtn_1.Enabled = false;
            this.rbtn_1.Location = new System.Drawing.Point(175, 16);
            this.rbtn_1.Name = "rbtn_1";
            this.rbtn_1.Size = new System.Drawing.Size(33, 21);
            this.rbtn_1.TabIndex = 19;
            this.rbtn_1.TabStop = true;
            this.rbtn_1.Text = "I";
            this.rbtn_1.UseVisualStyleBackColor = true;
            // 
            // rbtn_2
            // 
            this.rbtn_2.AutoSize = true;
            this.rbtn_2.Enabled = false;
            this.rbtn_2.Location = new System.Drawing.Point(261, 16);
            this.rbtn_2.Name = "rbtn_2";
            this.rbtn_2.Size = new System.Drawing.Size(37, 21);
            this.rbtn_2.TabIndex = 20;
            this.rbtn_2.TabStop = true;
            this.rbtn_2.Text = "II";
            this.rbtn_2.UseVisualStyleBackColor = true;
            // 
            // gbx_ciclo
            // 
            this.gbx_ciclo.Controls.Add(this.rbtn_1);
            this.gbx_ciclo.Controls.Add(this.rbtn_2);
            this.gbx_ciclo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_ciclo.ForeColor = System.Drawing.Color.Teal;
            this.gbx_ciclo.Location = new System.Drawing.Point(52, 243);
            this.gbx_ciclo.Name = "gbx_ciclo";
            this.gbx_ciclo.Size = new System.Drawing.Size(410, 57);
            this.gbx_ciclo.TabIndex = 22;
            this.gbx_ciclo.TabStop = false;
            this.gbx_ciclo.Text = "Ciclo";
            // 
            // datetp_fecha
            // 
            this.datetp_fecha.Location = new System.Drawing.Point(228, 193);
            this.datetp_fecha.Name = "datetp_fecha";
            this.datetp_fecha.Size = new System.Drawing.Size(159, 22);
            this.datetp_fecha.TabIndex = 23;
            this.datetp_fecha.ValueChanged += new System.EventHandler(this.datetp_fecha_ValueChanged);
            this.datetp_fecha.VisibleChanged += new System.EventHandler(this.datetp_fecha_VisibleChanged);
            this.datetp_fecha.MouseCaptureChanged += new System.EventHandler(this.datetp_fecha_MouseCaptureChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(63, 529);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 56;
            this.label8.Text = "Atras";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Presentacion.Properties.Resources.bbc500b6_9f12_45e0_b75d_1df036f6c47c;
            this.pictureBox3.Location = new System.Drawing.Point(12, 517);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 55;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Heavy", 16F);
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(83, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(370, 34);
            this.label2.TabIndex = 57;
            this.label2.Text = "Nuevo Proceso de Admisión";
            // 
            // VentanaNuevoProcesoAdmision
            // 
            this.AcceptButton = this.BtnRegistrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(520, 566);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.datetp_fecha);
            this.Controls.Add(this.gbx_ciclo);
            this.Controls.Add(this.lbl_prueba);
            this.Controls.Add(this.cmbx_tipoProceso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Vacantes);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.BtnVacantes);
            this.Controls.Add(this.BtnDescripcion);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "VentanaNuevoProcesoAdmision";
            this.Text = "Nuevo Proceso de Admision";
            this.Load += new System.EventHandler(this.VentanaNuevoProcesoAdmision_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.VentanaNuevoProcesoAdmision_Paint);
            this.gbx_ciclo.ResumeLayout(false);
            this.gbx_ciclo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BtnDescripcion;
        private System.Windows.Forms.Label BtnVacantes;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_Vacantes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbx_tipoProceso;
        private System.Windows.Forms.Label lbl_prueba;
        private System.Windows.Forms.RadioButton rbtn_1;
        private System.Windows.Forms.RadioButton rbtn_2;
        private System.Windows.Forms.GroupBox gbx_ciclo;
        private System.Windows.Forms.DateTimePicker datetp_fecha;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
    }
}
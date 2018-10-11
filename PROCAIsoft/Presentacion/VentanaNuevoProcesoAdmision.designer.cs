﻿namespace Presentacion
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
            this.label3 = new System.Windows.Forms.Label();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.textBox_Vacantes = new System.Windows.Forms.TextBox();
            this.label_nuevoProcesoAdmision = new System.Windows.Forms.Label();
            this.label_mm = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_dirigido = new System.Windows.Forms.ComboBox();
            this.txt_mes = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BtnDescripcion
            // 
            this.BtnDescripcion.AutoSize = true;
            this.BtnDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.BtnDescripcion.ForeColor = System.Drawing.Color.Teal;
            this.BtnDescripcion.Location = new System.Drawing.Point(45, 63);
            this.BtnDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BtnDescripcion.Name = "BtnDescripcion";
            this.BtnDescripcion.Size = new System.Drawing.Size(121, 13);
            this.BtnDescripcion.TabIndex = 0;
            this.BtnDescripcion.Text = "Nombre del Proceso";
            this.BtnDescripcion.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtnVacantes
            // 
            this.BtnVacantes.AutoSize = true;
            this.BtnVacantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.BtnVacantes.ForeColor = System.Drawing.Color.Teal;
            this.BtnVacantes.Location = new System.Drawing.Point(45, 115);
            this.BtnVacantes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BtnVacantes.Name = "BtnVacantes";
            this.BtnVacantes.Size = new System.Drawing.Size(60, 13);
            this.BtnVacantes.TabIndex = 1;
            this.BtnVacantes.Text = "Vacantes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(45, 171);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Location = new System.Drawing.Point(245, 280);
            this.BtnRegistrar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(67, 28);
            this.BtnRegistrar.TabIndex = 4;
            this.BtnRegistrar.Text = "Registar";
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            this.BtnRegistrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(91, 280);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(68, 28);
            this.BtnCancel.TabIndex = 5;
            this.BtnCancel.Text = "Cancelar";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Location = new System.Drawing.Point(170, 63);
            this.textBox_nombre.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(177, 20);
            this.textBox_nombre.TabIndex = 6;
            this.textBox_nombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox_Vacantes
            // 
            this.textBox_Vacantes.Location = new System.Drawing.Point(170, 112);
            this.textBox_Vacantes.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Vacantes.Name = "textBox_Vacantes";
            this.textBox_Vacantes.Size = new System.Drawing.Size(50, 20);
            this.textBox_Vacantes.TabIndex = 7;
            // 
            // label_nuevoProcesoAdmision
            // 
            this.label_nuevoProcesoAdmision.AutoSize = true;
            this.label_nuevoProcesoAdmision.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label_nuevoProcesoAdmision.ForeColor = System.Drawing.Color.Teal;
            this.label_nuevoProcesoAdmision.Location = new System.Drawing.Point(88, 20);
            this.label_nuevoProcesoAdmision.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_nuevoProcesoAdmision.Name = "label_nuevoProcesoAdmision";
            this.label_nuevoProcesoAdmision.Size = new System.Drawing.Size(166, 13);
            this.label_nuevoProcesoAdmision.TabIndex = 10;
            this.label_nuevoProcesoAdmision.Text = "Nuevo Proceso de Admisión";
            // 
            // label_mm
            // 
            this.label_mm.AutoSize = true;
            this.label_mm.Location = new System.Drawing.Point(161, 173);
            this.label_mm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_mm.Name = "label_mm";
            this.label_mm.Size = new System.Drawing.Size(23, 13);
            this.label_mm.TabIndex = 11;
            this.label_mm.Text = "mm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(45, 231);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Dirigido a:";
            // 
            // txt_dirigido
            // 
            this.txt_dirigido.FormattingEnabled = true;
            this.txt_dirigido.Items.AddRange(new object[] {
            "Escolares",
            "No Escolares"});
            this.txt_dirigido.Location = new System.Drawing.Point(164, 231);
            this.txt_dirigido.Margin = new System.Windows.Forms.Padding(2);
            this.txt_dirigido.Name = "txt_dirigido";
            this.txt_dirigido.Size = new System.Drawing.Size(121, 21);
            this.txt_dirigido.TabIndex = 15;
            // 
            // txt_mes
            // 
            this.txt_mes.FormattingEnabled = true;
            this.txt_mes.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.txt_mes.Location = new System.Drawing.Point(193, 173);
            this.txt_mes.Margin = new System.Windows.Forms.Padding(2);
            this.txt_mes.Name = "txt_mes";
            this.txt_mes.Size = new System.Drawing.Size(92, 21);
            this.txt_mes.TabIndex = 16;
            // 
            // VentanaNuevoProcesoAdmision
            // 
            this.AcceptButton = this.BtnRegistrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(390, 334);
            this.Controls.Add(this.txt_mes);
            this.Controls.Add(this.txt_dirigido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_mm);
            this.Controls.Add(this.label_nuevoProcesoAdmision);
            this.Controls.Add(this.textBox_Vacantes);
            this.Controls.Add(this.textBox_nombre);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnVacantes);
            this.Controls.Add(this.BtnDescripcion);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VentanaNuevoProcesoAdmision";
            this.Text = "Nuevo Proceso de Admision";
            this.Load += new System.EventHandler(this.VentanaNuevoProcesoAdmision_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.VentanaNuevoProcesoAdmision_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BtnDescripcion;
        private System.Windows.Forms.Label BtnVacantes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.TextBox textBox_Vacantes;
        private System.Windows.Forms.Label label_nuevoProcesoAdmision;
        private System.Windows.Forms.Label label_mm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txt_dirigido;
        private System.Windows.Forms.ComboBox txt_mes;
    }
}
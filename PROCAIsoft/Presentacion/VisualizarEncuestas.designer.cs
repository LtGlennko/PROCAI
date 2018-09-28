namespace Presentacion
{
    partial class frmRegYeditEncuestas
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
            this.labelNumeroGrupo = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelPregunta1 = new System.Windows.Forms.Label();
            this.labelPregunta2 = new System.Windows.Forms.Label();
            this.labelPregunta3 = new System.Windows.Forms.Label();
            this.labelPregunta4 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.dateEncuentra = new System.Windows.Forms.DateTimePicker();
            this.numPregunta1 = new System.Windows.Forms.NumericUpDown();
            this.numPregunta2 = new System.Windows.Forms.NumericUpDown();
            this.numPregunta3 = new System.Windows.Forms.NumericUpDown();
            this.numPregunta4 = new System.Windows.Forms.NumericUpDown();
            this.btnRetresar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dgvEncuestas = new System.Windows.Forms.DataGridView();
            this.NumGrupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaEncuesta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pregunta1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pregunta2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pregunta3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pregunta4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnModificar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPregunta1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPregunta2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPregunta3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPregunta4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEncuestas)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNumeroGrupo
            // 
            this.labelNumeroGrupo.AutoSize = true;
            this.labelNumeroGrupo.Location = new System.Drawing.Point(30, 23);
            this.labelNumeroGrupo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNumeroGrupo.Name = "labelNumeroGrupo";
            this.labelNumeroGrupo.Size = new System.Drawing.Size(133, 13);
            this.labelNumeroGrupo.TabIndex = 0;
            this.labelNumeroGrupo.Text = "ID del grupo perteneciente";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(30, 60);
            this.labelFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(120, 13);
            this.labelFecha.TabIndex = 1;
            this.labelFecha.Text = "Fecha de la encuentra :";
            // 
            // labelPregunta1
            // 
            this.labelPregunta1.AutoSize = true;
            this.labelPregunta1.Location = new System.Drawing.Point(30, 96);
            this.labelPregunta1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPregunta1.Name = "labelPregunta1";
            this.labelPregunta1.Size = new System.Drawing.Size(65, 13);
            this.labelPregunta1.TabIndex = 2;
            this.labelPregunta1.Text = "Pregunta 1 :";
            // 
            // labelPregunta2
            // 
            this.labelPregunta2.AutoSize = true;
            this.labelPregunta2.Location = new System.Drawing.Point(30, 127);
            this.labelPregunta2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPregunta2.Name = "labelPregunta2";
            this.labelPregunta2.Size = new System.Drawing.Size(65, 13);
            this.labelPregunta2.TabIndex = 3;
            this.labelPregunta2.Text = "Pregunta 2 :";
            // 
            // labelPregunta3
            // 
            this.labelPregunta3.AutoSize = true;
            this.labelPregunta3.Location = new System.Drawing.Point(30, 161);
            this.labelPregunta3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPregunta3.Name = "labelPregunta3";
            this.labelPregunta3.Size = new System.Drawing.Size(65, 13);
            this.labelPregunta3.TabIndex = 4;
            this.labelPregunta3.Text = "Pregunta 3 :";
            // 
            // labelPregunta4
            // 
            this.labelPregunta4.AutoSize = true;
            this.labelPregunta4.Location = new System.Drawing.Point(30, 195);
            this.labelPregunta4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPregunta4.Name = "labelPregunta4";
            this.labelPregunta4.Size = new System.Drawing.Size(65, 13);
            this.labelPregunta4.TabIndex = 5;
            this.labelPregunta4.Text = "Pregunta 4 :";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(245, 23);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(135, 20);
            this.txtNumero.TabIndex = 6;
            // 
            // dateEncuentra
            // 
            this.dateEncuentra.Location = new System.Drawing.Point(245, 57);
            this.dateEncuentra.Margin = new System.Windows.Forms.Padding(2);
            this.dateEncuentra.Name = "dateEncuentra";
            this.dateEncuentra.Size = new System.Drawing.Size(135, 20);
            this.dateEncuentra.TabIndex = 12;
            this.dateEncuentra.Value = new System.DateTime(2018, 9, 26, 18, 50, 1, 0);
            // 
            // numPregunta1
            // 
            this.numPregunta1.Location = new System.Drawing.Point(245, 96);
            this.numPregunta1.Margin = new System.Windows.Forms.Padding(2);
            this.numPregunta1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numPregunta1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPregunta1.Name = "numPregunta1";
            this.numPregunta1.Size = new System.Drawing.Size(80, 20);
            this.numPregunta1.TabIndex = 13;
            this.numPregunta1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numPregunta2
            // 
            this.numPregunta2.Location = new System.Drawing.Point(245, 127);
            this.numPregunta2.Margin = new System.Windows.Forms.Padding(2);
            this.numPregunta2.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numPregunta2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPregunta2.Name = "numPregunta2";
            this.numPregunta2.Size = new System.Drawing.Size(80, 20);
            this.numPregunta2.TabIndex = 14;
            this.numPregunta2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numPregunta3
            // 
            this.numPregunta3.Location = new System.Drawing.Point(245, 161);
            this.numPregunta3.Margin = new System.Windows.Forms.Padding(2);
            this.numPregunta3.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numPregunta3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPregunta3.Name = "numPregunta3";
            this.numPregunta3.Size = new System.Drawing.Size(80, 20);
            this.numPregunta3.TabIndex = 15;
            this.numPregunta3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numPregunta4
            // 
            this.numPregunta4.Location = new System.Drawing.Point(245, 195);
            this.numPregunta4.Margin = new System.Windows.Forms.Padding(2);
            this.numPregunta4.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numPregunta4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPregunta4.Name = "numPregunta4";
            this.numPregunta4.Size = new System.Drawing.Size(80, 20);
            this.numPregunta4.TabIndex = 16;
            this.numPregunta4.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnRetresar
            // 
            this.btnRetresar.Location = new System.Drawing.Point(29, 458);
            this.btnRetresar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRetresar.Name = "btnRetresar";
            this.btnRetresar.Size = new System.Drawing.Size(92, 27);
            this.btnRetresar.TabIndex = 17;
            this.btnRetresar.Text = "Atrás";
            this.btnRetresar.UseVisualStyleBackColor = true;
            this.btnRetresar.Click += new System.EventHandler(this.btnRetresar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(469, 46);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(85, 27);
            this.btnRegistrar.TabIndex = 18;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgvEncuestas
            // 
            this.dgvEncuestas.AllowUserToOrderColumns = true;
            this.dgvEncuestas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEncuestas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumGrupo,
            this.FechaEncuesta,
            this.Pregunta1,
            this.Pregunta2,
            this.Pregunta3,
            this.Pregunta4});
            this.dgvEncuestas.Location = new System.Drawing.Point(12, 231);
            this.dgvEncuestas.Name = "dgvEncuestas";
            this.dgvEncuestas.Size = new System.Drawing.Size(582, 211);
            this.dgvEncuestas.TabIndex = 19;
            this.dgvEncuestas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // NumGrupo
            // 
            this.NumGrupo.HeaderText = "NumGrupoEncuesta";
            this.NumGrupo.Name = "NumGrupo";
            // 
            // FechaEncuesta
            // 
            this.FechaEncuesta.HeaderText = "Fecha";
            this.FechaEncuesta.Name = "FechaEncuesta";
            // 
            // Pregunta1
            // 
            this.Pregunta1.HeaderText = "Pregunta 1";
            this.Pregunta1.Name = "Pregunta1";
            this.Pregunta1.Width = 40;
            // 
            // Pregunta2
            // 
            this.Pregunta2.HeaderText = "Pregunta 2";
            this.Pregunta2.Name = "Pregunta2";
            this.Pregunta2.Width = 40;
            // 
            // Pregunta3
            // 
            this.Pregunta3.HeaderText = "Pregunta 3";
            this.Pregunta3.Name = "Pregunta3";
            this.Pregunta3.Width = 40;
            // 
            // Pregunta4
            // 
            this.Pregunta4.HeaderText = "Pregunta 4";
            this.Pregunta4.Name = "Pregunta4";
            this.Pregunta4.Width = 40;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(469, 91);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(85, 27);
            this.btnModificar.TabIndex = 20;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(469, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 27);
            this.button1.TabIndex = 21;
            this.button1.Text = "Visualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmRegYeditEncuestas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 496);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dgvEncuestas);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnRetresar);
            this.Controls.Add(this.numPregunta4);
            this.Controls.Add(this.numPregunta3);
            this.Controls.Add(this.numPregunta2);
            this.Controls.Add(this.numPregunta1);
            this.Controls.Add(this.dateEncuentra);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.labelPregunta4);
            this.Controls.Add(this.labelPregunta3);
            this.Controls.Add(this.labelPregunta2);
            this.Controls.Add(this.labelPregunta1);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.labelNumeroGrupo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmRegYeditEncuestas";
            this.Text = "Encuestas Registradas";
            this.Load += new System.EventHandler(this.frmRegYeditEncuestas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPregunta1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPregunta2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPregunta3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPregunta4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEncuestas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumeroGrupo;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelPregunta1;
        private System.Windows.Forms.Label labelPregunta2;
        private System.Windows.Forms.Label labelPregunta3;
        private System.Windows.Forms.Label labelPregunta4;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.DateTimePicker dateEncuentra;
        private System.Windows.Forms.NumericUpDown numPregunta1;
        private System.Windows.Forms.NumericUpDown numPregunta2;
        private System.Windows.Forms.NumericUpDown numPregunta3;
        private System.Windows.Forms.NumericUpDown numPregunta4;
        private System.Windows.Forms.Button btnRetresar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridView dgvEncuestas;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumGrupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaEncuesta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pregunta1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pregunta2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pregunta3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pregunta4;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button button1;
    }
}
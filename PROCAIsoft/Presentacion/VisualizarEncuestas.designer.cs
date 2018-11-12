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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegYeditEncuestas));
            this.labelNumeroGrupo = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.dateEncuentra = new System.Windows.Forms.DateTimePicker();
            this.dgvEncuestas = new System.Windows.Forms.DataGridView();
            this.NumGrupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaEncuesta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pregunta1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pregunta2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pregunta3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pregunta4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnModificar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.rdBtnP1_1 = new System.Windows.Forms.RadioButton();
            this.rdBtnP1_2 = new System.Windows.Forms.RadioButton();
            this.rdBtnP1_3 = new System.Windows.Forms.RadioButton();
            this.rdBtnP1_4 = new System.Windows.Forms.RadioButton();
            this.rdBtnP1_5 = new System.Windows.Forms.RadioButton();
            this.btnBusca = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpP1 = new System.Windows.Forms.GroupBox();
            this.grpP2 = new System.Windows.Forms.GroupBox();
            this.rdBtnP2_1 = new System.Windows.Forms.RadioButton();
            this.rdBtnP2_2 = new System.Windows.Forms.RadioButton();
            this.rdBtnP2_3 = new System.Windows.Forms.RadioButton();
            this.rdBtnP2_4 = new System.Windows.Forms.RadioButton();
            this.rdBtnP2_5 = new System.Windows.Forms.RadioButton();
            this.grpP3 = new System.Windows.Forms.GroupBox();
            this.rdBtnP3_1 = new System.Windows.Forms.RadioButton();
            this.rdBtnP3_2 = new System.Windows.Forms.RadioButton();
            this.rdBtnP3_3 = new System.Windows.Forms.RadioButton();
            this.rdBtnP3_4 = new System.Windows.Forms.RadioButton();
            this.rdBtnP3_5 = new System.Windows.Forms.RadioButton();
            this.grpP4 = new System.Windows.Forms.GroupBox();
            this.rdBtnP4_1 = new System.Windows.Forms.RadioButton();
            this.rdBtnP4_2 = new System.Windows.Forms.RadioButton();
            this.rdBtnP4_3 = new System.Windows.Forms.RadioButton();
            this.rdBtnP4_4 = new System.Windows.Forms.RadioButton();
            this.rdBtnP4_5 = new System.Windows.Forms.RadioButton();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblTipoEncuesta = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.grpBoxGrupo = new System.Windows.Forms.GroupBox();
            this.btnEncuestaGrupo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cboGuia = new System.Windows.Forms.ComboBox();
            this.cboActividad = new System.Windows.Forms.ComboBox();
            this.cboColegio = new System.Windows.Forms.ComboBox();
            this.labelGuia = new System.Windows.Forms.Label();
            this.labelColegio = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelF = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEncuestas)).BeginInit();
            this.grpP1.SuspendLayout();
            this.grpP2.SuspendLayout();
            this.grpP3.SuspendLayout();
            this.grpP4.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.grpBoxGrupo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNumeroGrupo
            // 
            this.labelNumeroGrupo.AutoSize = true;
            this.labelNumeroGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroGrupo.ForeColor = System.Drawing.Color.Teal;
            this.labelNumeroGrupo.Location = new System.Drawing.Point(9, 65);
            this.labelNumeroGrupo.Name = "labelNumeroGrupo";
            this.labelNumeroGrupo.Size = new System.Drawing.Size(118, 20);
            this.labelNumeroGrupo.TabIndex = 0;
            this.labelNumeroGrupo.Text = "ID del grupo :";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.ForeColor = System.Drawing.Color.Teal;
            this.labelFecha.Location = new System.Drawing.Point(506, -20);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(182, 20);
            this.labelFecha.TabIndex = 1;
            this.labelFecha.Text = "Fecha de la encuesta";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(140, 58);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(72, 30);
            this.txtNumero.TabIndex = 6;
            // 
            // dateEncuentra
            // 
            this.dateEncuentra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEncuentra.Location = new System.Drawing.Point(231, 52);
            this.dateEncuentra.Name = "dateEncuentra";
            this.dateEncuentra.Size = new System.Drawing.Size(242, 26);
            this.dateEncuentra.TabIndex = 12;
            this.dateEncuentra.Value = new System.DateTime(2018, 9, 26, 18, 50, 1, 0);
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
            this.dgvEncuestas.Location = new System.Drawing.Point(38, 794);
            this.dgvEncuestas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvEncuestas.Name = "dgvEncuestas";
            this.dgvEncuestas.Size = new System.Drawing.Size(837, 242);
            this.dgvEncuestas.TabIndex = 19;
            this.dgvEncuestas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEncuestas_CellDoubleClick);
            // 
            // NumGrupo
            // 
            this.NumGrupo.DataPropertyName = "IdGrupoPerteneciente";
            this.NumGrupo.HeaderText = "ID Grupo";
            this.NumGrupo.Name = "NumGrupo";
            this.NumGrupo.Width = 60;
            // 
            // FechaEncuesta
            // 
            this.FechaEncuesta.DataPropertyName = "FechaProgramada";
            this.FechaEncuesta.HeaderText = "Fecha de llenado";
            this.FechaEncuesta.Name = "FechaEncuesta";
            this.FechaEncuesta.Width = 130;
            // 
            // Pregunta1
            // 
            this.Pregunta1.DataPropertyName = "CalificacionP1";
            this.Pregunta1.HeaderText = "Preg 1";
            this.Pregunta1.Name = "Pregunta1";
            this.Pregunta1.Width = 40;
            // 
            // Pregunta2
            // 
            this.Pregunta2.DataPropertyName = "CalificacionP2";
            this.Pregunta2.HeaderText = "Preg 2";
            this.Pregunta2.Name = "Pregunta2";
            this.Pregunta2.Width = 40;
            // 
            // Pregunta3
            // 
            this.Pregunta3.DataPropertyName = "CalificacionP3";
            this.Pregunta3.HeaderText = "Preg 3";
            this.Pregunta3.Name = "Pregunta3";
            this.Pregunta3.Width = 40;
            // 
            // Pregunta4
            // 
            this.Pregunta4.DataPropertyName = "CalificacionP4";
            this.Pregunta4.HeaderText = "Preg 4";
            this.Pregunta4.Name = "Pregunta4";
            this.Pregunta4.Width = 40;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.White;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(628, 262);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(129, 43);
            this.btnModificar.TabIndex = 20;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(628, 332);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 43);
            this.button1.TabIndex = 21;
            this.button1.Text = "Visualizar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdBtnP1_1
            // 
            this.rdBtnP1_1.AutoSize = true;
            this.rdBtnP1_1.Location = new System.Drawing.Point(24, 26);
            this.rdBtnP1_1.Name = "rdBtnP1_1";
            this.rdBtnP1_1.Size = new System.Drawing.Size(44, 24);
            this.rdBtnP1_1.TabIndex = 23;
            this.rdBtnP1_1.TabStop = true;
            this.rdBtnP1_1.Text = "1";
            this.rdBtnP1_1.UseVisualStyleBackColor = true;
            // 
            // rdBtnP1_2
            // 
            this.rdBtnP1_2.AutoSize = true;
            this.rdBtnP1_2.Location = new System.Drawing.Point(105, 26);
            this.rdBtnP1_2.Name = "rdBtnP1_2";
            this.rdBtnP1_2.Size = new System.Drawing.Size(44, 24);
            this.rdBtnP1_2.TabIndex = 24;
            this.rdBtnP1_2.TabStop = true;
            this.rdBtnP1_2.Text = "2";
            this.rdBtnP1_2.UseVisualStyleBackColor = true;
            // 
            // rdBtnP1_3
            // 
            this.rdBtnP1_3.AutoSize = true;
            this.rdBtnP1_3.Checked = true;
            this.rdBtnP1_3.Location = new System.Drawing.Point(186, 26);
            this.rdBtnP1_3.Name = "rdBtnP1_3";
            this.rdBtnP1_3.Size = new System.Drawing.Size(44, 24);
            this.rdBtnP1_3.TabIndex = 25;
            this.rdBtnP1_3.TabStop = true;
            this.rdBtnP1_3.Text = "3";
            this.rdBtnP1_3.UseVisualStyleBackColor = true;
            // 
            // rdBtnP1_4
            // 
            this.rdBtnP1_4.AutoSize = true;
            this.rdBtnP1_4.Location = new System.Drawing.Point(264, 26);
            this.rdBtnP1_4.Name = "rdBtnP1_4";
            this.rdBtnP1_4.Size = new System.Drawing.Size(44, 24);
            this.rdBtnP1_4.TabIndex = 26;
            this.rdBtnP1_4.TabStop = true;
            this.rdBtnP1_4.Text = "4";
            this.rdBtnP1_4.UseVisualStyleBackColor = true;
            // 
            // rdBtnP1_5
            // 
            this.rdBtnP1_5.AutoSize = true;
            this.rdBtnP1_5.Location = new System.Drawing.Point(339, 26);
            this.rdBtnP1_5.Name = "rdBtnP1_5";
            this.rdBtnP1_5.Size = new System.Drawing.Size(44, 24);
            this.rdBtnP1_5.TabIndex = 27;
            this.rdBtnP1_5.TabStop = true;
            this.rdBtnP1_5.Text = "5";
            this.rdBtnP1_5.UseVisualStyleBackColor = true;
            // 
            // btnBusca
            // 
            this.btnBusca.BackColor = System.Drawing.Color.White;
            this.btnBusca.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBusca.Location = new System.Drawing.Point(224, 57);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(58, 32);
            this.btnBusca.TabIndex = 43;
            this.btnBusca.Text = "...";
            this.btnBusca.UseVisualStyleBackColor = false;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(94, 1069);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 45;
            this.label1.Text = "Atras";
            // 
            // grpP1
            // 
            this.grpP1.Controls.Add(this.rdBtnP1_1);
            this.grpP1.Controls.Add(this.rdBtnP1_2);
            this.grpP1.Controls.Add(this.rdBtnP1_3);
            this.grpP1.Controls.Add(this.rdBtnP1_4);
            this.grpP1.Controls.Add(this.rdBtnP1_5);
            this.grpP1.Controls.Add(this.labelFecha);
            this.grpP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.grpP1.ForeColor = System.Drawing.Color.Teal;
            this.grpP1.Location = new System.Drawing.Point(50, 488);
            this.grpP1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpP1.Name = "grpP1";
            this.grpP1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpP1.Size = new System.Drawing.Size(576, 63);
            this.grpP1.TabIndex = 46;
            this.grpP1.TabStop = false;
            this.grpP1.Text = "Pregunta 1";
            // 
            // grpP2
            // 
            this.grpP2.Controls.Add(this.rdBtnP2_1);
            this.grpP2.Controls.Add(this.rdBtnP2_2);
            this.grpP2.Controls.Add(this.rdBtnP2_3);
            this.grpP2.Controls.Add(this.rdBtnP2_4);
            this.grpP2.Controls.Add(this.rdBtnP2_5);
            this.grpP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.grpP2.ForeColor = System.Drawing.Color.Teal;
            this.grpP2.Location = new System.Drawing.Point(50, 560);
            this.grpP2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpP2.Name = "grpP2";
            this.grpP2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpP2.Size = new System.Drawing.Size(576, 63);
            this.grpP2.TabIndex = 47;
            this.grpP2.TabStop = false;
            this.grpP2.Text = "Pregunta 2";
            // 
            // rdBtnP2_1
            // 
            this.rdBtnP2_1.AutoSize = true;
            this.rdBtnP2_1.Location = new System.Drawing.Point(24, 26);
            this.rdBtnP2_1.Name = "rdBtnP2_1";
            this.rdBtnP2_1.Size = new System.Drawing.Size(44, 24);
            this.rdBtnP2_1.TabIndex = 23;
            this.rdBtnP2_1.TabStop = true;
            this.rdBtnP2_1.Text = "1";
            this.rdBtnP2_1.UseVisualStyleBackColor = true;
            // 
            // rdBtnP2_2
            // 
            this.rdBtnP2_2.AutoSize = true;
            this.rdBtnP2_2.Location = new System.Drawing.Point(105, 26);
            this.rdBtnP2_2.Name = "rdBtnP2_2";
            this.rdBtnP2_2.Size = new System.Drawing.Size(44, 24);
            this.rdBtnP2_2.TabIndex = 24;
            this.rdBtnP2_2.TabStop = true;
            this.rdBtnP2_2.Text = "2";
            this.rdBtnP2_2.UseVisualStyleBackColor = true;
            // 
            // rdBtnP2_3
            // 
            this.rdBtnP2_3.AutoSize = true;
            this.rdBtnP2_3.Checked = true;
            this.rdBtnP2_3.Location = new System.Drawing.Point(186, 26);
            this.rdBtnP2_3.Name = "rdBtnP2_3";
            this.rdBtnP2_3.Size = new System.Drawing.Size(44, 24);
            this.rdBtnP2_3.TabIndex = 25;
            this.rdBtnP2_3.TabStop = true;
            this.rdBtnP2_3.Text = "3";
            this.rdBtnP2_3.UseVisualStyleBackColor = true;
            // 
            // rdBtnP2_4
            // 
            this.rdBtnP2_4.AutoSize = true;
            this.rdBtnP2_4.Location = new System.Drawing.Point(264, 26);
            this.rdBtnP2_4.Name = "rdBtnP2_4";
            this.rdBtnP2_4.Size = new System.Drawing.Size(44, 24);
            this.rdBtnP2_4.TabIndex = 26;
            this.rdBtnP2_4.TabStop = true;
            this.rdBtnP2_4.Text = "4";
            this.rdBtnP2_4.UseVisualStyleBackColor = true;
            // 
            // rdBtnP2_5
            // 
            this.rdBtnP2_5.AutoSize = true;
            this.rdBtnP2_5.Location = new System.Drawing.Point(339, 26);
            this.rdBtnP2_5.Name = "rdBtnP2_5";
            this.rdBtnP2_5.Size = new System.Drawing.Size(44, 24);
            this.rdBtnP2_5.TabIndex = 27;
            this.rdBtnP2_5.TabStop = true;
            this.rdBtnP2_5.Text = "5";
            this.rdBtnP2_5.UseVisualStyleBackColor = true;
            // 
            // grpP3
            // 
            this.grpP3.Controls.Add(this.rdBtnP3_1);
            this.grpP3.Controls.Add(this.rdBtnP3_2);
            this.grpP3.Controls.Add(this.rdBtnP3_3);
            this.grpP3.Controls.Add(this.rdBtnP3_4);
            this.grpP3.Controls.Add(this.rdBtnP3_5);
            this.grpP3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.grpP3.ForeColor = System.Drawing.Color.Teal;
            this.grpP3.Location = new System.Drawing.Point(50, 632);
            this.grpP3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpP3.Name = "grpP3";
            this.grpP3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpP3.Size = new System.Drawing.Size(576, 63);
            this.grpP3.TabIndex = 47;
            this.grpP3.TabStop = false;
            this.grpP3.Text = "Pregunta 3";
            // 
            // rdBtnP3_1
            // 
            this.rdBtnP3_1.AutoSize = true;
            this.rdBtnP3_1.Location = new System.Drawing.Point(24, 26);
            this.rdBtnP3_1.Name = "rdBtnP3_1";
            this.rdBtnP3_1.Size = new System.Drawing.Size(44, 24);
            this.rdBtnP3_1.TabIndex = 23;
            this.rdBtnP3_1.TabStop = true;
            this.rdBtnP3_1.Text = "1";
            this.rdBtnP3_1.UseVisualStyleBackColor = true;
            // 
            // rdBtnP3_2
            // 
            this.rdBtnP3_2.AutoSize = true;
            this.rdBtnP3_2.Location = new System.Drawing.Point(105, 26);
            this.rdBtnP3_2.Name = "rdBtnP3_2";
            this.rdBtnP3_2.Size = new System.Drawing.Size(44, 24);
            this.rdBtnP3_2.TabIndex = 24;
            this.rdBtnP3_2.TabStop = true;
            this.rdBtnP3_2.Text = "2";
            this.rdBtnP3_2.UseVisualStyleBackColor = true;
            // 
            // rdBtnP3_3
            // 
            this.rdBtnP3_3.AutoSize = true;
            this.rdBtnP3_3.Checked = true;
            this.rdBtnP3_3.Location = new System.Drawing.Point(186, 26);
            this.rdBtnP3_3.Name = "rdBtnP3_3";
            this.rdBtnP3_3.Size = new System.Drawing.Size(44, 24);
            this.rdBtnP3_3.TabIndex = 25;
            this.rdBtnP3_3.TabStop = true;
            this.rdBtnP3_3.Text = "3";
            this.rdBtnP3_3.UseVisualStyleBackColor = true;
            // 
            // rdBtnP3_4
            // 
            this.rdBtnP3_4.AutoSize = true;
            this.rdBtnP3_4.Location = new System.Drawing.Point(264, 26);
            this.rdBtnP3_4.Name = "rdBtnP3_4";
            this.rdBtnP3_4.Size = new System.Drawing.Size(44, 24);
            this.rdBtnP3_4.TabIndex = 26;
            this.rdBtnP3_4.TabStop = true;
            this.rdBtnP3_4.Text = "4";
            this.rdBtnP3_4.UseVisualStyleBackColor = true;
            // 
            // rdBtnP3_5
            // 
            this.rdBtnP3_5.AutoSize = true;
            this.rdBtnP3_5.Location = new System.Drawing.Point(339, 26);
            this.rdBtnP3_5.Name = "rdBtnP3_5";
            this.rdBtnP3_5.Size = new System.Drawing.Size(44, 24);
            this.rdBtnP3_5.TabIndex = 27;
            this.rdBtnP3_5.TabStop = true;
            this.rdBtnP3_5.Text = "5";
            this.rdBtnP3_5.UseVisualStyleBackColor = true;
            // 
            // grpP4
            // 
            this.grpP4.Controls.Add(this.rdBtnP4_1);
            this.grpP4.Controls.Add(this.rdBtnP4_2);
            this.grpP4.Controls.Add(this.rdBtnP4_3);
            this.grpP4.Controls.Add(this.rdBtnP4_4);
            this.grpP4.Controls.Add(this.rdBtnP4_5);
            this.grpP4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.grpP4.ForeColor = System.Drawing.Color.Teal;
            this.grpP4.Location = new System.Drawing.Point(50, 705);
            this.grpP4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpP4.Name = "grpP4";
            this.grpP4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpP4.Size = new System.Drawing.Size(576, 63);
            this.grpP4.TabIndex = 47;
            this.grpP4.TabStop = false;
            this.grpP4.Text = "Pregunta 4";
            // 
            // rdBtnP4_1
            // 
            this.rdBtnP4_1.AutoSize = true;
            this.rdBtnP4_1.Location = new System.Drawing.Point(24, 26);
            this.rdBtnP4_1.Name = "rdBtnP4_1";
            this.rdBtnP4_1.Size = new System.Drawing.Size(44, 24);
            this.rdBtnP4_1.TabIndex = 23;
            this.rdBtnP4_1.TabStop = true;
            this.rdBtnP4_1.Text = "1";
            this.rdBtnP4_1.UseVisualStyleBackColor = true;
            // 
            // rdBtnP4_2
            // 
            this.rdBtnP4_2.AutoSize = true;
            this.rdBtnP4_2.Location = new System.Drawing.Point(105, 26);
            this.rdBtnP4_2.Name = "rdBtnP4_2";
            this.rdBtnP4_2.Size = new System.Drawing.Size(44, 24);
            this.rdBtnP4_2.TabIndex = 24;
            this.rdBtnP4_2.TabStop = true;
            this.rdBtnP4_2.Text = "2";
            this.rdBtnP4_2.UseVisualStyleBackColor = true;
            // 
            // rdBtnP4_3
            // 
            this.rdBtnP4_3.AutoSize = true;
            this.rdBtnP4_3.Checked = true;
            this.rdBtnP4_3.Location = new System.Drawing.Point(186, 26);
            this.rdBtnP4_3.Name = "rdBtnP4_3";
            this.rdBtnP4_3.Size = new System.Drawing.Size(44, 24);
            this.rdBtnP4_3.TabIndex = 25;
            this.rdBtnP4_3.TabStop = true;
            this.rdBtnP4_3.Text = "3";
            this.rdBtnP4_3.UseVisualStyleBackColor = true;
            // 
            // rdBtnP4_4
            // 
            this.rdBtnP4_4.AutoSize = true;
            this.rdBtnP4_4.Location = new System.Drawing.Point(264, 26);
            this.rdBtnP4_4.Name = "rdBtnP4_4";
            this.rdBtnP4_4.Size = new System.Drawing.Size(44, 24);
            this.rdBtnP4_4.TabIndex = 26;
            this.rdBtnP4_4.TabStop = true;
            this.rdBtnP4_4.Text = "4";
            this.rdBtnP4_4.UseVisualStyleBackColor = true;
            // 
            // rdBtnP4_5
            // 
            this.rdBtnP4_5.AutoSize = true;
            this.rdBtnP4_5.Location = new System.Drawing.Point(339, 26);
            this.rdBtnP4_5.Name = "rdBtnP4_5";
            this.rdBtnP4_5.Size = new System.Drawing.Size(44, 24);
            this.rdBtnP4_5.TabIndex = 27;
            this.rdBtnP4_5.TabStop = true;
            this.rdBtnP4_5.Text = "5";
            this.rdBtnP4_5.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.White;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(628, 192);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(129, 43);
            this.btnAgregar.TabIndex = 48;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblTipoEncuesta
            // 
            this.lblTipoEncuesta.AutoSize = true;
            this.lblTipoEncuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoEncuesta.ForeColor = System.Drawing.Color.Teal;
            this.lblTipoEncuesta.Location = new System.Drawing.Point(9, 126);
            this.lblTipoEncuesta.Name = "lblTipoEncuesta";
            this.lblTipoEncuesta.Size = new System.Drawing.Size(92, 20);
            this.lblTipoEncuesta.TabIndex = 49;
            this.lblTipoEncuesta.Text = "Actividad :";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.AliceBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(20, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(513, 26);
            this.label2.TabIndex = 50;
            this.label2.Text = "De 1 (No en absoluto) a 5 (Si totalmente) :";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnGuardar,
            this.toolStripSeparator});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(909, 32);
            this.toolStrip1.TabIndex = 51;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(92, 29);
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(103, 29);
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 32);
            // 
            // grpBoxGrupo
            // 
            this.grpBoxGrupo.Controls.Add(this.btnEncuestaGrupo);
            this.grpBoxGrupo.Controls.Add(this.label3);
            this.grpBoxGrupo.Controls.Add(this.cboGuia);
            this.grpBoxGrupo.Controls.Add(this.cboActividad);
            this.grpBoxGrupo.Controls.Add(this.cboColegio);
            this.grpBoxGrupo.Controls.Add(this.labelGuia);
            this.grpBoxGrupo.Controls.Add(this.labelColegio);
            this.grpBoxGrupo.Controls.Add(this.labelNumeroGrupo);
            this.grpBoxGrupo.Controls.Add(this.txtNumero);
            this.grpBoxGrupo.Controls.Add(this.lblTipoEncuesta);
            this.grpBoxGrupo.Controls.Add(this.btnBusca);
            this.grpBoxGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxGrupo.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.grpBoxGrupo.Location = new System.Drawing.Point(38, 52);
            this.grpBoxGrupo.Name = "grpBoxGrupo";
            this.grpBoxGrupo.Size = new System.Drawing.Size(837, 303);
            this.grpBoxGrupo.TabIndex = 52;
            this.grpBoxGrupo.TabStop = false;
            this.grpBoxGrupo.Text = "Grupo ";
            // 
            // btnEncuestaGrupo
            // 
            this.btnEncuestaGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncuestaGrupo.Location = new System.Drawing.Point(258, 244);
            this.btnEncuestaGrupo.Name = "btnEncuestaGrupo";
            this.btnEncuestaGrupo.Size = new System.Drawing.Size(119, 35);
            this.btnEncuestaGrupo.TabIndex = 56;
            this.btnEncuestaGrupo.Text = "Encuestas";
            this.btnEncuestaGrupo.UseVisualStyleBackColor = true;
            this.btnEncuestaGrupo.Click += new System.EventHandler(this.btnEncuestaGrupo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(9, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 20);
            this.label3.TabIndex = 55;
            this.label3.Text = "Ver las encuestas del grupo :";
            // 
            // cboGuia
            // 
            this.cboGuia.FormattingEnabled = true;
            this.cboGuia.Location = new System.Drawing.Point(198, 180);
            this.cboGuia.Name = "cboGuia";
            this.cboGuia.Size = new System.Drawing.Size(604, 33);
            this.cboGuia.TabIndex = 54;
            // 
            // cboActividad
            // 
            this.cboActividad.FormattingEnabled = true;
            this.cboActividad.Location = new System.Drawing.Point(200, 122);
            this.cboActividad.Name = "cboActividad";
            this.cboActividad.Size = new System.Drawing.Size(602, 33);
            this.cboActividad.TabIndex = 53;
            // 
            // cboColegio
            // 
            this.cboColegio.FormattingEnabled = true;
            this.cboColegio.Location = new System.Drawing.Point(578, 60);
            this.cboColegio.Name = "cboColegio";
            this.cboColegio.Size = new System.Drawing.Size(224, 33);
            this.cboColegio.TabIndex = 52;
            // 
            // labelGuia
            // 
            this.labelGuia.AutoSize = true;
            this.labelGuia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGuia.ForeColor = System.Drawing.Color.Teal;
            this.labelGuia.Location = new System.Drawing.Point(9, 188);
            this.labelGuia.Name = "labelGuia";
            this.labelGuia.Size = new System.Drawing.Size(134, 20);
            this.labelGuia.TabIndex = 51;
            this.labelGuia.Text = "Guia evaluado :";
            // 
            // labelColegio
            // 
            this.labelColegio.AutoSize = true;
            this.labelColegio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColegio.ForeColor = System.Drawing.Color.Teal;
            this.labelColegio.Location = new System.Drawing.Point(380, 65);
            this.labelColegio.Name = "labelColegio";
            this.labelColegio.Size = new System.Drawing.Size(180, 20);
            this.labelColegio.TabIndex = 50;
            this.labelColegio.Text = "Nombre del Colegio : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelF);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateEncuentra);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(38, 361);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(837, 425);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encuesta";
            // 
            // labelF
            // 
            this.labelF.AutoSize = true;
            this.labelF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelF.ForeColor = System.Drawing.Color.Teal;
            this.labelF.Location = new System.Drawing.Point(18, 52);
            this.labelF.Name = "labelF";
            this.labelF.Size = new System.Drawing.Size(192, 20);
            this.labelF.TabIndex = 55;
            this.labelF.Text = "Fecha de la encuesta :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.bbc500b6_9f12_45e0_b75d_1df036f6c47c;
            this.pictureBox1.Location = new System.Drawing.Point(22, 1049);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // frmRegYeditEncuestas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(909, 1050);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.grpP4);
            this.Controls.Add(this.grpP3);
            this.Controls.Add(this.grpP2);
            this.Controls.Add(this.grpP1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvEncuestas);
            this.Controls.Add(this.grpBoxGrupo);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Name = "frmRegYeditEncuestas";
            this.Text = "Encuestas Registradas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEncuestas)).EndInit();
            this.grpP1.ResumeLayout(false);
            this.grpP1.PerformLayout();
            this.grpP2.ResumeLayout(false);
            this.grpP2.PerformLayout();
            this.grpP3.ResumeLayout(false);
            this.grpP3.PerformLayout();
            this.grpP4.ResumeLayout(false);
            this.grpP4.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grpBoxGrupo.ResumeLayout(false);
            this.grpBoxGrupo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumeroGrupo;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.DateTimePicker dateEncuentra;
        private System.Windows.Forms.DataGridView dgvEncuestas;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rdBtnP1_1;
        private System.Windows.Forms.RadioButton rdBtnP1_2;
        private System.Windows.Forms.RadioButton rdBtnP1_3;
        private System.Windows.Forms.RadioButton rdBtnP1_4;
        private System.Windows.Forms.RadioButton rdBtnP1_5;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpP1;
        private System.Windows.Forms.GroupBox grpP2;
        private System.Windows.Forms.RadioButton rdBtnP2_1;
        private System.Windows.Forms.RadioButton rdBtnP2_2;
        private System.Windows.Forms.RadioButton rdBtnP2_3;
        private System.Windows.Forms.RadioButton rdBtnP2_4;
        private System.Windows.Forms.RadioButton rdBtnP2_5;
        private System.Windows.Forms.GroupBox grpP3;
        private System.Windows.Forms.RadioButton rdBtnP3_1;
        private System.Windows.Forms.RadioButton rdBtnP3_2;
        private System.Windows.Forms.RadioButton rdBtnP3_3;
        private System.Windows.Forms.RadioButton rdBtnP3_4;
        private System.Windows.Forms.RadioButton rdBtnP3_5;
        private System.Windows.Forms.GroupBox grpP4;
        private System.Windows.Forms.RadioButton rdBtnP4_1;
        private System.Windows.Forms.RadioButton rdBtnP4_2;
        private System.Windows.Forms.RadioButton rdBtnP4_3;
        private System.Windows.Forms.RadioButton rdBtnP4_4;
        private System.Windows.Forms.RadioButton rdBtnP4_5;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumGrupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaEncuesta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pregunta1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pregunta2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pregunta3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pregunta4;
        private System.Windows.Forms.Label lblTipoEncuesta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.GroupBox grpBoxGrupo;
        private System.Windows.Forms.Label labelGuia;
        private System.Windows.Forms.Label labelColegio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelF;
        private System.Windows.Forms.ComboBox cboGuia;
        private System.Windows.Forms.ComboBox cboActividad;
        private System.Windows.Forms.ComboBox cboColegio;
        private System.Windows.Forms.Button btnEncuestaGrupo;
        private System.Windows.Forms.Label label3;
    }
}
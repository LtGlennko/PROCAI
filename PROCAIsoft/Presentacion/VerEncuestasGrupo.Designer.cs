namespace Presentacion
{
    partial class VerEncuestasGrupo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerEncuestasGrupo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idEncuesta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preg1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preg2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preg3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preg4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel_superior = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel_superior.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Teal;
            this.groupBox1.Location = new System.Drawing.Point(91, 121);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(855, 440);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encuestas del Grupo";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEncuesta,
            this.Preg1,
            this.Preg2,
            this.Preg3,
            this.Preg4});
            this.dataGridView1.Location = new System.Drawing.Point(17, 42);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(757, 367);
            this.dataGridView1.TabIndex = 0;
            // 
            // idEncuesta
            // 
            this.idEncuesta.DataPropertyName = "IdEncuesta1";
            this.idEncuesta.HeaderText = "ID Encuesta";
            this.idEncuesta.Name = "idEncuesta";
            this.idEncuesta.ReadOnly = true;
            // 
            // Preg1
            // 
            this.Preg1.DataPropertyName = "CalificacionP1";
            this.Preg1.HeaderText = "Preg 1";
            this.Preg1.Name = "Preg1";
            this.Preg1.ReadOnly = true;
            // 
            // Preg2
            // 
            this.Preg2.DataPropertyName = "CalificacionP2";
            this.Preg2.HeaderText = "Preg 2";
            this.Preg2.Name = "Preg2";
            this.Preg2.ReadOnly = true;
            // 
            // Preg3
            // 
            this.Preg3.DataPropertyName = "CalificacionP3";
            this.Preg3.HeaderText = "Preg 3";
            this.Preg3.Name = "Preg3";
            this.Preg3.ReadOnly = true;
            // 
            // Preg4
            // 
            this.Preg4.DataPropertyName = "CalificacionP4";
            this.Preg4.HeaderText = "Preg 4";
            this.Preg4.Name = "Preg4";
            this.Preg4.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(63, 563);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 21);
            this.label8.TabIndex = 56;
            this.label8.Text = "Atras";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Presentacion.Properties.Resources.bbc500b6_9f12_45e0_b75d_1df036f6c47c;
            this.pictureBox3.Location = new System.Drawing.Point(12, 553);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 55;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // panel_superior
            // 
            this.panel_superior.BackColor = System.Drawing.Color.Teal;
            this.panel_superior.Controls.Add(this.label3);
            this.panel_superior.Location = new System.Drawing.Point(-2, -1);
            this.panel_superior.Name = "panel_superior";
            this.panel_superior.Size = new System.Drawing.Size(1045, 114);
            this.panel_superior.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(85, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(408, 45);
            this.label3.TabIndex = 57;
            this.label3.Text = "Encuestas por Grupo";
            // 
            // VerEncuestasGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1037, 602);
            this.Controls.Add(this.panel_superior);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "VerEncuestasGrupo";
            this.Text = "VerEncuestasGrupo";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel_superior.ResumeLayout(false);
            this.panel_superior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEncuesta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preg1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preg2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preg3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preg4;
        private System.Windows.Forms.Panel panel_superior;
        private System.Windows.Forms.Label label3;
    }
}
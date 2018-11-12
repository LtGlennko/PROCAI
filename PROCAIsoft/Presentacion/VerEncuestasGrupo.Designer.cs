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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preg1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preg2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preg3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preg4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(782, 516);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encuestas del Grupo";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Preg1,
            this.Preg2,
            this.Preg3,
            this.Preg4});
            this.dataGridView1.Location = new System.Drawing.Point(19, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(746, 418);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Fecha";
            this.Column1.Name = "Column1";
            // 
            // Preg1
            // 
            this.Preg1.HeaderText = "Preg 1";
            this.Preg1.Name = "Preg1";
            // 
            // Preg2
            // 
            this.Preg2.HeaderText = "Preg 2";
            this.Preg2.Name = "Preg2";
            // 
            // Preg3
            // 
            this.Preg3.HeaderText = "Preg 3";
            this.Preg3.Name = "Preg3";
            // 
            // Preg4
            // 
            this.Preg4.HeaderText = "Preg 4";
            this.Preg4.Name = "Preg4";
            // 
            // VerEncuestasGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 614);
            this.Controls.Add(this.groupBox1);
            this.Name = "VerEncuestasGrupo";
            this.Text = "VerEncuestasGrupo";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preg1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preg2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preg3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preg4;
    }
}
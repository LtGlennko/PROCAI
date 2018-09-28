namespace Presentacion
{
    partial class EditarStocks
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad:";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(166, 77);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(124, 20);
            this.txtN.TabIndex = 2;
            this.txtN.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(166, 132);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(124, 20);
            this.txtC.TabIndex = 3;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(166, 257);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Código:";
            // 
            // txtCod
            // 
            this.txtCod.Enabled = false;
            this.txtCod.Location = new System.Drawing.Point(166, 185);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(124, 20);
            this.txtCod.TabIndex = 7;
            // 
            // EditarStocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 380);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditarStocks";
            this.Text = "editarStocks";
            this.Load += new System.EventHandler(this.editarStockcs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCod;
    }
}
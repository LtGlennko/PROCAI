using System.Drawing;

namespace Presentacion
{
    partial class agregarStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(agregarStock));
            this.txtNombre = new System.Windows.Forms.Label();
            this.txtCant = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.labelAtras = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSize = true;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.txtNombre.ForeColor = System.Drawing.Color.Teal;
            this.txtNombre.Location = new System.Drawing.Point(106, 71);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(54, 13);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.Text = "Nombre:";
            this.txtNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCant
            // 
            this.txtCant.AutoSize = true;
            this.txtCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.txtCant.ForeColor = System.Drawing.Color.Teal;
            this.txtCant.Location = new System.Drawing.Point(99, 112);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(61, 13);
            this.txtCant.TabIndex = 1;
            this.txtCant.Text = "Cantidad:";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(170, 71);
            this.txtN.MaxLength = 30;
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(123, 20);
            this.txtN.TabIndex = 2;
            this.txtN.TextChanged += new System.EventHandler(this.txtN_TextChanged);
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(170, 109);
            this.txtC.MaxLength = 5;
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(123, 20);
            this.txtC.TabIndex = 3;
            this.txtC.TextChanged += new System.EventHandler(this.txtC_TextChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(256, 248);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(85, 21);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Heavy", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(143, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Agregar Stock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(82, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Descripcion:";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(170, 143);
            this.txtDesc.MaxLength = 100;
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(123, 73);
            this.txtDesc.TabIndex = 9;
            this.txtDesc.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelAtras
            // 
            this.labelAtras.AutoSize = true;
            this.labelAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAtras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelAtras.Location = new System.Drawing.Point(50, 291);
            this.labelAtras.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAtras.Name = "labelAtras";
            this.labelAtras.Size = new System.Drawing.Size(36, 13);
            this.labelAtras.TabIndex = 11;
            this.labelAtras.Text = "Atras";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.bbc500b6_9f12_45e0_b75d_1df036f6c47c;
            this.pictureBox1.Location = new System.Drawing.Point(9, 284);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // agregarStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(429, 324);
            this.Controls.Add(this.labelAtras);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.txtCant);
            this.Controls.Add(this.txtNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "agregarStock";
            this.Text = "agregarStock";
            this.Load += new System.EventHandler(this.agregarStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label txtNombre;
        private System.Windows.Forms.Label txtCant;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label labelAtras;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
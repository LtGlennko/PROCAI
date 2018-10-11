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
            this.txtNombre = new System.Windows.Forms.Label();
            this.txtCant = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSize = true;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.txtNombre.ForeColor = System.Drawing.Color.Teal;
            this.txtNombre.Location = new System.Drawing.Point(99, 74);
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
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(123, 20);
            this.txtN.TabIndex = 2;
            this.txtN.TextChanged += new System.EventHandler(this.txtN_TextChanged);
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(170, 109);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(123, 20);
            this.txtC.TabIndex = 3;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(102, 182);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(85, 21);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(252, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // agregarStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(429, 324);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.txtCant);
            this.Controls.Add(this.txtNombre);
            this.Name = "agregarStock";
            this.Text = "agregarStock";
            this.Load += new System.EventHandler(this.agregarStock_Load);
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
        private System.Windows.Forms.Button button1;
    }
}
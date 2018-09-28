namespace Presentacion
{
    partial class Gestionar_permisos
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
            this.dvgUsuarios = new System.Windows.Forms.DataGridView();
            this.txtNivel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seleccione usuario a modificar";
            // 
            // dvgUsuarios
            // 
            this.dvgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgUsuarios.Location = new System.Drawing.Point(34, 53);
            this.dvgUsuarios.Name = "dvgUsuarios";
            this.dvgUsuarios.Size = new System.Drawing.Size(473, 274);
            this.dvgUsuarios.TabIndex = 2;
            this.dvgUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgUsuarios_CellContentClick);
            // 
            // txtNivel
            // 
            this.txtNivel.Location = new System.Drawing.Point(397, 18);
            this.txtNivel.Name = "txtNivel";
            this.txtNivel.Size = new System.Drawing.Size(30, 20);
            this.txtNivel.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ingrese el nuevo nivel a ingresar";
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(34, 342);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 5;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(392, 342);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(115, 23);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar cambios";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(435, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Gestionar_permisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 385);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNivel);
            this.Controls.Add(this.dvgUsuarios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Gestionar_permisos";
            this.Text = "Gestionar permisos";
            this.Load += new System.EventHandler(this.Gestionar_permisos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dvgUsuarios;
        private System.Windows.Forms.TextBox txtNivel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button button1;
    }
}
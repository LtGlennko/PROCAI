namespace Presentacion
{
    partial class DetalleNivelPermiso
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
            this.cboCargo = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblCargo = new System.Windows.Forms.Label();
            this.chkJefe = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboCargo
            // 
            this.cboCargo.FormattingEnabled = true;
            this.cboCargo.Location = new System.Drawing.Point(164, 95);
            this.cboCargo.Name = "cboCargo";
            this.cboCargo.Size = new System.Drawing.Size(121, 21);
            this.cboCargo.TabIndex = 0;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(329, 161);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(92, 103);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(35, 13);
            this.lblCargo.TabIndex = 3;
            this.lblCargo.Text = "Cargo";
            // 
            // chkJefe
            // 
            this.chkJefe.AutoSize = true;
            this.chkJefe.Location = new System.Drawing.Point(74, 150);
            this.chkJefe.Name = "chkJefe";
            this.chkJefe.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkJefe.Size = new System.Drawing.Size(73, 17);
            this.chkJefe.TabIndex = 4;
            this.chkJefe.Text = "?Es jefe¿ ";
            this.chkJefe.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(121, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nivel de permiso de usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nobre de ususario";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(164, 58);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(108, 13);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "<nombre de Usuario>";
            // 
            // DetalleNivelPermiso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(416, 196);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkJefe);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cboCargo);
            this.Name = "DetalleNivelPermiso";
            this.Text = "DetalleNivelPermiso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCargo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.CheckBox chkJefe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNombre;
    }
}
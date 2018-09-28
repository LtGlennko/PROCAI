namespace Presentacion
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.llblOlvido = new System.Windows.Forms.LinkLabel();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.lb = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblUsuInval = new System.Windows.Forms.Label();
            this.lblConInval = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(54, 70);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario";
            this.lblUsuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(50, 98);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(61, 13);
            this.lblContraseña.TabIndex = 1;
            this.lblContraseña.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(117, 67);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.Text = "Administrativo1";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(117, 95);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(100, 20);
            this.txtContraseña.TabIndex = 3;
            // 
            // llblOlvido
            // 
            this.llblOlvido.AutoSize = true;
            this.llblOlvido.Location = new System.Drawing.Point(108, 130);
            this.llblOlvido.Name = "llblOlvido";
            this.llblOlvido.Size = new System.Drawing.Size(119, 13);
            this.llblOlvido.TabIndex = 4;
            this.llblOlvido.TabStop = true;
            this.llblOlvido.Text = "¿Olvido su contraseña?";
            this.llblOlvido.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblOlvido_LinkClicked);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(129, 153);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 5;
            this.btnIniciar.Text = "Iniciar Sesion";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(154, 31);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(32, 13);
            this.lb.TabIndex = 6;
            this.lb.Text = "OCAI";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(12, 153);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(50, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblUsuInval
            // 
            this.lblUsuInval.AutoSize = true;
            this.lblUsuInval.Location = new System.Drawing.Point(223, 70);
            this.lblUsuInval.Name = "lblUsuInval";
            this.lblUsuInval.Size = new System.Drawing.Size(0, 13);
            this.lblUsuInval.TabIndex = 8;
            // 
            // lblConInval
            // 
            this.lblConInval.AutoSize = true;
            this.lblConInval.Location = new System.Drawing.Point(223, 98);
            this.lblConInval.Name = "lblConInval";
            this.lblConInval.Size = new System.Drawing.Size(0, 13);
            this.lblConInval.TabIndex = 9;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 188);
            this.Controls.Add(this.lblConInval);
            this.Controls.Add(this.lblUsuInval);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.llblOlvido);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblUsuario);
            this.Name = "Login";
            this.Text = "SISTEMA OCAI";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.LinkLabel llblOlvido;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblUsuInval;
        private System.Windows.Forms.Label lblConInval;
    }
}


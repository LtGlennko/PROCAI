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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(109, 92);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario";
            this.lblUsuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(109, 145);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(61, 13);
            this.lblContraseña.TabIndex = 1;
            this.lblContraseña.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(176, 89);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.Text = "Ejecutivo2";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(176, 142);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(100, 20);
            this.txtContraseña.TabIndex = 3;
            this.txtContraseña.Text = "1234";
            // 
            // llblOlvido
            // 
            this.llblOlvido.AutoSize = true;
            this.llblOlvido.Location = new System.Drawing.Point(128, 226);
            this.llblOlvido.Name = "llblOlvido";
            this.llblOlvido.Size = new System.Drawing.Size(119, 13);
            this.llblOlvido.TabIndex = 4;
            this.llblOlvido.TabStop = true;
            this.llblOlvido.Text = "¿Olvido su contraseña?";
            this.llblOlvido.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblOlvido_LinkClicked);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(134, 193);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(106, 23);
            this.btnIniciar.TabIndex = 5;
            this.btnIniciar.Text = "Iniciar Sesion";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Bauhaus 93", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.Location = new System.Drawing.Point(87, 30);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(187, 28);
            this.lb.TabIndex = 6;
            this.lb.Text = "PROCAIsoft v0.1";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(12, 221);
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
            this.lblUsuInval.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuInval.Location = new System.Drawing.Point(182, 114);
            this.lblUsuInval.Name = "lblUsuInval";
            this.lblUsuInval.Size = new System.Drawing.Size(0, 13);
            this.lblUsuInval.TabIndex = 8;
            // 
            // lblConInval
            // 
            this.lblConInval.AutoSize = true;
            this.lblConInval.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConInval.Location = new System.Drawing.Point(182, 167);
            this.lblConInval.Name = "lblConInval";
            this.lblConInval.Size = new System.Drawing.Size(0, 13);
            this.lblConInval.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(85, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(85, 143);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 256);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}


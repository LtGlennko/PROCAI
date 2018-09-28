using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Login : Form
    {
        private BindingList<Usuario> usuarios;
        private static int numIntentos = 3;
        public Login()
        {
            InitializeComponent();
            usuarios = new BindingList<Usuario>();
            Usuario u1 = new Administrativo(Convert.ToDateTime("05-07-2018"), 2, Convert.ToDateTime("10-08-2018"), 1, 4533436, 987676543, "rSanchez67@yahoo.com");
            Usuario u2 = new Ejecutivo(Convert.ToDateTime("06-07-2018"), 1, Convert.ToDateTime("29-06-2018"), 1, 3217717, 938482121, "valefc@gmail.com");
            Usuario u3 = new Guia(Convert.ToDateTime("23-09-2018"), 3, Convert.ToDateTime("16-07-2018"), 1, 'C', "Vigente");
            Usuario u4 = new Usuario(Convert.ToDateTime("17-04-2018"), 5); //Este es un jefe por ser nivel 5
            Usuario u5 = new Usuario(Convert.ToDateTime("30-08-2018"), 4);
            CuentaUsuario c1 = new CuentaUsuario(Convert.ToDateTime("10-09-2018"), "Administrativo1", "1234", u1);
            CuentaUsuario c2 = new CuentaUsuario(Convert.ToDateTime("10-09-2018"), "Ejecutivo2", "1234", u2);
            CuentaUsuario c3 = new CuentaUsuario(Convert.ToDateTime("10-09-2018"), "Guia3", "1234", u3);
            CuentaUsuario c4 = new CuentaUsuario(Convert.ToDateTime("10-09-2018"), "Jefe4", "1234", u4);
            CuentaUsuario c5 = new CuentaUsuario(Convert.ToDateTime("10-09-2018"), "LMAO", "1234", u5);
            usuarios.Add(u1);
            usuarios.Add(u2);
            usuarios.Add(u3);
            usuarios.Add(u4);
            usuarios.Add(u5);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if(numIntentos == 0)
            {
                MessageBox.Show("Ha excedido el número de intentos, espere 5 minutos");
                return;
            }

            //formularioDelJefe f = formularioDelJefe();
            if (txtUsuario.Text == "")
            {
                lblUsuInval.Text = "Usuario no ingresado";
                return;
            }
            lblUsuInval.Text = "";
            if (txtContraseña.Text == "")
            {
                lblConInval.Text = "Constraseña no válida";
                return;
            }
            lblConInval.Text = "";
            this.Visible = false;
            Usuario usuIn = buscarUsuario(txtUsuario.Text, txtContraseña.Text);

            if(usuIn == null)
            {               
                MessageBox.Show("Ingreso fallido, le quedan " + numIntentos + " intentos");
                --numIntentos;
                return;
            }

            if (usuIn is Administrativo)
            {
                InicioAdministrativo IA = new InicioAdministrativo(usuIn);
                IA.StartPosition = FormStartPosition.CenterScreen;
                if (IA.ShowDialog() == DialogResult.OK)
                {

                }
            }

            if (usuIn is Ejecutivo)
            {
                InicioEjecutivo IG = new InicioEjecutivo(usuIn);
                IG.StartPosition = FormStartPosition.CenterScreen;
                if (IG.ShowDialog() == DialogResult.OK)
                {

                }
            }

            if (usuIn is Guia)
            {
                InicioGuia IE = new InicioGuia(usuIn);
                IE.StartPosition = FormStartPosition.CenterScreen;
                if (IE.ShowDialog() == DialogResult.OK)
                {

                }
            }
            if (usuIn.NivelPermiso == 5) //El jefe tiene un nivel de permiso 5
            {
                InicioJefe IJ = new InicioJefe(usuarios, usuIn);
                //Close();
                IJ.StartPosition = FormStartPosition.CenterScreen;
                if (IJ.ShowDialog() == DialogResult.OK)
                {

                }
                this.Visible = true;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void llblOlvido_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OlvidoContraseña p = new OlvidoContraseña();
            p.StartPosition = FormStartPosition.CenterScreen;
            if (p.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        
        public Usuario buscarUsuario(string nombre, string contra)
        {
            foreach(Usuario usu in usuarios)
            {
                if (usu.NombreUsuario.Equals(nombre) && usu.CuentaUsuario.Contrasena.Equals(contra)) return usu;
            }
            return null;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}

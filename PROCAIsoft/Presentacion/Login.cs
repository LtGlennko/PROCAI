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
        private static int numIntentos = 3;
        public Login()
        {
            InitializeComponent();
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

            if (usuIn is Usuario)
            {
                InicioAdministrativo IA = new InicioAdministrativo(usuIn);
                IA.StartPosition = FormStartPosition.CenterScreen;
                this.Visible = false;
                if (IA.ShowDialog() == DialogResult.OK)
                {

                }
                this.Visible = true;
            }

            if (usuIn is Usuario)
            {
                InicioEjecutivo IG = new InicioEjecutivo(usuIn);
                IG.StartPosition = FormStartPosition.CenterScreen;
                this.Visible = false;
                if (IG.ShowDialog() == DialogResult.OK)
                {

                }
                this.Visible = true;
            }

            if (usuIn is Guia)
            {
                InicioGuia IE = new InicioGuia(usuIn);
                IE.StartPosition = FormStartPosition.CenterScreen;
                this.Visible = false;
                if (IE.ShowDialog() == DialogResult.OK)
                {

                }
                this.Visible = true;
            }
            if (usuIn.NivelPermiso == 5) //El jefe tiene un nivel de permiso 5
            {
                InicioJefe IJ = new InicioJefe(usuIn);
                IJ.StartPosition = FormStartPosition.CenterScreen;
                this.Visible = false;
                if (IJ.ShowDialog() == DialogResult.OK)
                {

                }
                this.Visible = true;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void lblOlvido_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
            //BUSCAR USUARIO
            return null;
        }
    }
}

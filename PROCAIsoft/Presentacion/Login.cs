﻿using LogicaNegocio;
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
        private UsuarioBL usuarioBL;
        private GuiaBL guiaBL;
        private TrabajadorOCAIBL trabajadorOCAIBL;
        private Usuario usuarioBuscado;
        private static int numIntentos = 3;

        public DateTime MyNullableDate { get; private set; }

        public Login()
        {
            usuarioBL = new UsuarioBL();
            guiaBL = new GuiaBL();
            trabajadorOCAIBL = new TrabajadorOCAIBL();
            InitializeComponent();
        }


        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if(numIntentos == 0)
            {
                MessageBox.Show("Ha excedido el número de intentos, espere 5 minutos");
                return;
            }

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
            string nomUsuario = txtUsuario.Text;
            string contrasena = txtContraseña.Text;
            usuarioBuscado = usuarioBL.buscarUsuario(nomUsuario, contrasena);
            if (usuarioBuscado == null)
            {               
                MessageBox.Show("Ingreso fallido, le quedan " + numIntentos + " intentos");
                --numIntentos;
                return;
            }

            //0 Alumno, 1 Orientador, 2 Guia, 3 Administrativo, 4 Ejecutivo, 5 Jefe

            if (usuarioBuscado.NivelPermiso == 2)
            {
                Guia g = guiaBL.crearGuia(usuarioBuscado);
                if (g == null)
                {
                    MessageBox.Show("Error en la base de datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                InicioGuia IE = new InicioGuia(g);
                IE.StartPosition = FormStartPosition.CenterScreen;
                this.Visible = false;
                if (IE.ShowDialog() == DialogResult.OK)
                {

                }
                this.Visible = true;
            }


            if (usuarioBuscado.NivelPermiso == 3)
            {
                TrabajadorOCAI t = trabajadorOCAIBL.crearTrabajadorOCAI(usuarioBuscado);
                if (t == null)
                {
                    MessageBox.Show("Error en la base de datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                InicioAdministrativo IA = new InicioAdministrativo(t);
                IA.StartPosition = FormStartPosition.CenterScreen;
                this.Visible = false;
                if (IA.ShowDialog() == DialogResult.OK)
                {

                }
                this.Visible = true;
            }

            if (usuarioBuscado.NivelPermiso == 4)
            {
                TrabajadorOCAI t = trabajadorOCAIBL.crearTrabajadorOCAI(usuarioBuscado);
                if (t == null)
                {
                    MessageBox.Show("Error en la base de datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                InicioEjecutivo IG = new InicioEjecutivo(t);
                IG.StartPosition = FormStartPosition.CenterScreen;
                this.Visible = false;
                if (IG.ShowDialog() == DialogResult.OK)
                {

                }
                this.Visible = true;
            }

            //if (usuarioBuscado.NivelPermiso == 5) //El jefe tiene un nivel de permiso 5
            //{
            //    InicioJefe IJ = new InicioJefe(usuarioBuscado);
            //    IJ.StartPosition = FormStartPosition.CenterScreen;
            //    this.Visible = false;
            //    if (IJ.ShowDialog() == DialogResult.OK)
            //    {

            //    }
            //    this.Visible = true;
            //}
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
        
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;

namespace Presentacion
{
    public partial class InicioEjecutivo : Form
    {
        private frmGestStock gestionarStock;
        public InicioEjecutivo()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }
        public InicioEjecutivo(Usuario usu)
        {
            InitializeComponent();
            lblNombreUsu.Text += usu.NombreCuenta;
            this.IsMdiContainer = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnCalendario_Click(object sender, EventArgs e)
        {
            GestionCal IE = new GestionCal();
            IE.StartPosition = FormStartPosition.CenterScreen;
            this.Visible = false;
            if (IE.ShowDialog() == DialogResult.OK)
            {

            }
            this.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmProcesoAdm FP = new frmProcesoAdm();
            FP.StartPosition = FormStartPosition.CenterScreen;
            this.Visible = false;
            if (FP.ShowDialog() == DialogResult.OK)
            {

            }
            this.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GestionOrientadores GO = new GestionOrientadores();
            GO.StartPosition = FormStartPosition.CenterScreen;
            this.Visible = false;
            if (GO.ShowDialog() == DialogResult.OK)
            {

            }
            this.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmSolicitudes s = new frmSolicitudes();
            s.StartPosition = FormStartPosition.CenterScreen;
            this.Visible = false;
            if (s.ShowDialog() == DialogResult.OK)
            {

            }
            this.Visible = true;
        }

        private void InicioEjecutivo_Load(object sender, EventArgs e)
        {

        }

        private void btnGestionarColegios_Click(object sender, EventArgs e)
        {
            GestCol GS = new GestCol();
            GS.SetDesktopLocation(100, 100);
            this.Visible = false;
            if (GS.ShowDialog() == DialogResult.OK)
            {

            }
            this.Visible = true;
        }

        private void btnGestionarStock_Click(object sender, EventArgs e)
        {
            if (gestionarStock == null)
            {
                gestionarStock = new frmGestStock();
                gestionarStock.MdiParent = this;
                gestionarStock.Visible = true;
                gestionarStock.FormClosing += volverNulo;
                //FS.StartPosition = FormStartPosition.CenterScreen;
                ////this.Visible = false;
                //FS.MdiParent = this;
                //FS.Visible = true;
                //if (FS.ShowDialog() == DialogResult.OK)
                //{

                //}
            }

        }

        public void volverNulo(object sender, FormClosingEventArgs e)
        {
            gestionarStock = null;
        }
        
    }
}

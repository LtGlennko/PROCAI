﻿using Modelo;
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
    public partial class InicioAdministrativo : Form
    {
        public const int MIN_SIZE = 46;
        public const int MAX_SIZE = 215;
        private TrabajadorOCAI trabajador;
        public InicioAdministrativo(TrabajadorOCAI t)
        {
            InitializeComponent();
            trabajador = t;
            lblNombreUsu.Text += t.NombresYapellidos;
            if (!t.EsJefe)
            {
                btnGenerarReportes.Visible = false;
                btnGestionarPermisos.Visible = false;
                
            }
        }

        public InicioAdministrativo()
        {
            InitializeComponent();
            btnGenerarReportes.Visible = false;
            btnGestionarPermisos.Visible = false;
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ptrDespliegue_Click(object sender, EventArgs e)
        {
            if (pnlOpciones.Width == MAX_SIZE) pnlOpciones.Width = MIN_SIZE;
            else pnlOpciones.Width = MAX_SIZE;
        }

        //ESTE METODO DESLIEGA LA VENTANA EN EL PANEL
        private void abrirFormInPanel(object formHijo)
        {
            if (this.pnlVentanas.Controls.Count > 0)
                this.pnlVentanas.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.StartPosition = FormStartPosition.CenterParent;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.pnlVentanas.Controls.Add(fh);
            this.pnlVentanas.Tag = fh;
            fh.MouseEnter += new System.EventHandler(this.fh_MouseEnter);
            fh.Show();
        }

        private void fh_MouseEnter(object sender, EventArgs e)
        {
            pnlOpciones.Width = MIN_SIZE;
        }
        private void btnGestionarPermisos_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new Gestionar_permisos(trabajador));
        }

        private void btnGenerarReportes_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new GeneradorRepEncuestas());
        }

        private void btnGestionarPostulantes_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new frmVisualizarPostulantes());
        }

        

        private void pnlOpciones_MouseEnter(object sender, EventArgs e)
        {
            pnlOpciones.Width = MAX_SIZE;
        }

        private void btnGestionarPostulantes_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox2.Location = new System.Drawing.Point(pictureBox2.Location.X, btnGestionarPostulantes.Location.Y);

        }

        private void btnGestionarPermisos_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox2.Location = new System.Drawing.Point(pictureBox2.Location.X, btnGestionarPermisos.Location.Y);

        }

        private void btnGenerarReportes_DragEnter(object sender, DragEventArgs e)
        {
            this.pictureBox2.Location = new System.Drawing.Point(pictureBox2.Location.X, btnGenerarReportes.Location.Y);

        }

        private void btnGenerarReportes_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox2.Location = new System.Drawing.Point(pictureBox2.Location.X, btnGenerarReportes.Location.Y);

        }
    }
}

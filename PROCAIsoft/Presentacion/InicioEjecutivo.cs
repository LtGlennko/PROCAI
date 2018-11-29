using System;
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
        public const int MIN_SIZE = 46;
        public const int MAX_SIZE = 215;
        private TrabajadorOCAI trabajador;
        public InicioEjecutivo()
        {
            InitializeComponent();
            btnGenerarReportes.Visible = false;
            btnGestionarPermisos.Visible = false;
            //pictureBox8.Visible = false;
            //pictureBox9.Visible = false;
        }
        public InicioEjecutivo(TrabajadorOCAI t)
        {
            InitializeComponent();
            trabajador = t;
            lblNombreUsu.Text += t.NombresYapellidos;
            if (!t.EsJefe)
            {
                btnGenerarReportes.Visible = false;
                btnGestionarPermisos.Visible = false;
                //pictureBox8.Visible = false;
                //pictureBox9.Visible = false;
            }
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
        private void fh_MouseEnter(object sender, EventArgs e) {
            pnlOpciones.Width = MIN_SIZE;
        }
        private void btnGestionarStock_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new frmGestStock());
        }
        private void btnGestOrientadores_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new GestionOrientadores());
        }

        private void btnGestColegios_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new GestCol());
        }

        private void btnGestCalendario_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new GestionCal());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGestionarPermisos_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new Gestionar_permisos(trabajador));
        }

        private void btnGenerarReportes_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new GeneradorRepEncuestas());
        }

        private void btnGestProcesosAdm_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new frmProcesoAdm());
        }

        private void btnIncripcionAct_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new frmSolicitudes());
        }

        private void btnGestionTA_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new GestionTA());
        }
        
        private void pnlOpciones_MouseLeave(object sender, EventArgs e)
        {
            pnlOpciones.Width = MIN_SIZE;
        }

        private void pnlOpciones_MouseHover(object sender, EventArgs e)
        {
            //pnlOpciones.Width = MAX_SIZE;
        }

        private void pnlOpciones_MouseEnter(object sender, EventArgs e)
        {
            pnlOpciones.Width = MAX_SIZE;
        }

        private void pnlVentanas_MouseEnter(object sender, EventArgs e)
        {
            pnlOpciones.Width = MIN_SIZE;
        }

        private void btnGestColegios_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox2.Location = new System.Drawing.Point(pictureBox2.Location.X, btnGestColegios.Location.Y);
        }

        //private void btnGestCalendario_MouseEnter(object sender, EventArgs e)
        //{
        //    this.pictureBox2.Location = new System.Drawing.Point(pictureBox2.Location.X, btnGestCalendario.Location.Y);
        //}

        //private void btnGestOrientadores_MouseEnter(object sender, EventArgs e)
        //{
        //    this.pictureBox2.Location = new System.Drawing.Point(pictureBox2.Location.X, btnGestOrientadores.Location.Y);
        //}

        private void btnGestProcesosAdm_Enter(object sender, EventArgs e)
        {
            this.pictureBox2.Location = new System.Drawing.Point(pictureBox2.Location.X, btnGestProcesosAdm.Location.Y);
        }

        private void btnGestionarStock_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox2.Location = new System.Drawing.Point(pictureBox2.Location.X, btnGestionarStock.Location.Y);

        }

        private void btnGestProcesosAdm_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox2.Location = new System.Drawing.Point(pictureBox2.Location.X, btnGestProcesosAdm.Location.Y);
        }

        private void btnIncripcionAct_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox2.Location = new System.Drawing.Point(pictureBox2.Location.X, btnIncripcionAct.Location.Y);
        }

        private void btnGestionarPermisos_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox2.Location = new System.Drawing.Point(pictureBox2.Location.X, btnGestionarPermisos.Location.Y);
        }

        private void btnGenerarReportes_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox2.Location = new System.Drawing.Point(pictureBox2.Location.X, btnGenerarReportes.Location.Y);
        }

        private void btnGestionTA_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox2.Location = new System.Drawing.Point(pictureBox2.Location.X, btnGestionTA.Location.Y);
        }

        //private void mnuGestionarStock_Click(object sender, EventArgs e)
        //{
        //    if (gestionarStock == null)
        //    {
        //        gestionarStock = new frmGestStock();
        //        gestionarStock.MdiParent = this;
        //        gestionarStock.Visible = true;
        //        gestionarStock.FormClosing += volverNulo;
        //        //FS.StartPosition = FormStartPosition.CenterScreen;
        //        ////this.Visible = false;
        //        //FS.MdiParent = this;
        //        //FS.Visible = true;
        //        //if (FS.ShowDialog() == DialogResult.OK)
        //        //{

        //        //}
        //    }
        //}
    }
}

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
        public InicioEjecutivo(string username)
        {
            InitializeComponent();
            lblNombreUsu.Text += username;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmRegYeditEncuestas ME = new frmRegYeditEncuestas(1, 0);
            this.Visible = false;
            ME.StartPosition = FormStartPosition.CenterScreen;
            if (ME.ShowDialog() == DialogResult.OK)
            {

            }
            this.Visible = true;
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
            frmGestStock FS = new frmGestStock();
            FS.StartPosition = FormStartPosition.CenterScreen;
            this.Visible = false;
            if (FS.ShowDialog() == DialogResult.OK)
            {

            }
            this.Visible = true;
        }
    }
}

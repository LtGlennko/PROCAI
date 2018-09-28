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
        public InicioEjecutivo(Usuario u)
        {            
            InitializeComponent();
            lblNombreUsu.Text += u.NombreUsuario;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //FormStock FS = new FormStock();
            //FS.StartPosition = FormStartPosition.CenterScreen;
            //this.Visible = false;
            //if (FS.ShowDialog() == DialogResult.OK)
            //{

            //}
            //this.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            GestCol GS = new GestCol();
            GS.SetDesktopLocation(100, 100);
            this.Visible = false;
            if (GS.ShowDialog() == DialogResult.OK)
            {

            }
            this.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmRegYeditEncuestas ME = new frmRegYeditEncuestas(1);
            this.Visible = false;
            ME.StartPosition = FormStartPosition.CenterScreen;
            if (ME.ShowDialog() == DialogResult.OK)
            {

            }
            this.Visible = true;
        }

        private void button2_Click_2(object sender, EventArgs e)
        {

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
    }
}

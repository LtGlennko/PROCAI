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
    public partial class InicioGuia : Form
    {
        public const int MIN_SIZE = 46;
        public const int MAX_SIZE = 215;
        private Guia guia;
        public InicioGuia()
        {
            InitializeComponent();
        }
        public InicioGuia(Guia g)
        {
            InitializeComponent();
            guia = g;
            lblNombreUsu.Text += guia.NombresYapellidos;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            frmRegYeditEncuestas R = new frmRegYeditEncuestas(guia);
            this.Visible = false;
            R.StartPosition = FormStartPosition.CenterScreen;
            if (R.ShowDialog() == DialogResult.OK)
            {
            }
            this.Visible = true;
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
            fh.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void ptrDespliegue_Click(object sender, EventArgs e)
        {
            if (pnlOpciones.Width == MAX_SIZE) pnlOpciones.Width = MIN_SIZE;
            else pnlOpciones.Width = MAX_SIZE;
        }

        private void btnSugerirColegio_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new frmRegYeditEncuestas(guia));
        }

        private void pnlOpciones_MouseHover(object sender, EventArgs e)
        {
            pnlOpciones.Width = MAX_SIZE;
        }

        private void pnlOpciones_MouseLeave(object sender, EventArgs e)
        {
            //pnlOpciones.Width = MIN_SIZE;
        }
    }
}

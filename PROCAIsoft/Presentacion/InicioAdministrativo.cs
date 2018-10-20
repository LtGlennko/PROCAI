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
    public partial class InicioAdministrativo : Form
    {
        public InicioAdministrativo(Usuario usu)
        {            
            InitializeComponent();
            lblNombreUsu.Text += usu.NombreCuenta;
        }

        private void btnGestionarPostul_Click(object sender, EventArgs e)
        {
            frmVisualizarPostulantes VP = new frmVisualizarPostulantes();
            VP.SetDesktopLocation(100, 100);
            this.Visible = false;
            if (VP.ShowDialog() == DialogResult.OK)
            {

            }
            this.Visible = true;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void InicioAdministrativo_Load(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}

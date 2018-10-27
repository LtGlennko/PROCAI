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
        private Usuario usuGuia;
        public InicioGuia()
        {
            InitializeComponent();
        }
        public InicioGuia(Usuario usu)
        {
            InitializeComponent();
            usuGuia = usu;
            lblNombreUsu.Text += usu.NombreCuenta;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            frmRegYeditEncuestas R = new frmRegYeditEncuestas(usuGuia);
            this.Visible = false;
            R.StartPosition = FormStartPosition.CenterScreen;
            if (R.ShowDialog() == DialogResult.OK)
            {
            }
            this.Visible = true;
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

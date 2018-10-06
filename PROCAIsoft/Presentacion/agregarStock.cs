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
    public partial class agregarStock : Form
    {
        public agregarStock()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
           
            txtN.Text = String.Empty;
            txtC.Text = String.Empty;
            MessageBox.Show("Producto registrado");
            //if(DialogResult.OK==)
        }

        private void agregarStock_Load(object sender, EventArgs e)
        {

        }
    }
}

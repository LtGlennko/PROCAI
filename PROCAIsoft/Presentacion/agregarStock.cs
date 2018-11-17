using Modelo;
using System;
using LogicaNegocio;
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
        private MerchandisingBL mbl;
        public agregarStock()
        {
            InitializeComponent();
            mbl = new MerchandisingBL();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(txtC.Text);
            }
            catch
            {
                MessageBox.Show("Debe ingresar un número de stock valido", "Error Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtCant.Text.Length > 4)
            {
                MessageBox.Show("Debe ingresar número menor a 10000", "Error Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtN.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar nombre", "Error Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtN.Text.Length > 30 || txtN.Text.Length < 10)
            {
                MessageBox.Show("Tamaño de nombre invalido", "Error Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtDesc.Text.Length > 50)
            {
                MessageBox.Show("Debe ingresar descripcion menor a 50 caracteres", "Error Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Merchandising m = new Merchandising();
            m.Nombre = txtN.Text;
            m.Stock = Int32.Parse(txtC.Text);
            m.Descripcion = txtDesc.Text;
            mbl.registarMerchandising(m);
            txtN.Text = String.Empty;
            txtC.Text = String.Empty;
            MessageBox.Show("Producto registrado");
            this.DialogResult = DialogResult.OK;
            //if(DialogResult.OK==)
        }

        private void agregarStock_Load(object sender, EventArgs e)
        {

        }

        private void txtN_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }
    }
}

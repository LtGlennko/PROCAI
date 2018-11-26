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
using LogicaNegocio;
namespace Presentacion
{
    public partial class EditarStocks : Form
    {

        private MerchandisingBL mbl;
        public EditarStocks()
        {
            InitializeComponent();
            mbl = new MerchandisingBL();
        }

        
        public EditarStocks(int cod,string nomb,int stock,string descripcion)
        {
            InitializeComponent();
            txtCod.Text = cod.ToString();
            txtC.Text = stock.ToString();
            txtN.Text = nomb;
            txtDesc.Text = descripcion;
            mbl = new MerchandisingBL();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(txtC.Text);
            }
            catch
            {
                MessageBox.Show("Debe ingresar un número de stock valido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtDesc.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar descripcion", "Error Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtN.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar nombre", "Error Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtN.Text.Length > 30 || txtN.Text.Length < 10)
            {
                MessageBox.Show("Tamaño de nombre invalido", "Error Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtDesc.Text.Length > 50)
            {
                MessageBox.Show("Debe ingresar descripcion menor a 50 caracteres", "Error Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string nomb = txtN.Text;
            int cant = Int32.Parse(txtC.Text);
            int cod = Int32.Parse(txtCod.Text);
            string desc = txtDesc.Text;
            Merchandising m = new Merchandising(cod, nomb, desc, cant);
            mbl.actualizarMerchandising(m);
            //Modificado
            MessageBox.Show("Datos del producto modificado","Editar Merchandising",MessageBoxButtons.OK,MessageBoxIcon.Information);
            if (cant < 50)
            {
                MessageBox.Show("Quedan menos de 50 unidades de este merchandising", "Editar Merchandising", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //Modificado
            this.DialogResult = DialogResult.OK;
        }

        private void editarStockcs_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Dispose(true);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtC_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

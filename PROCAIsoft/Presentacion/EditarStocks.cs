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
    public partial class EditarStocks : Form
    {
        public EditarStocks()
        {
            InitializeComponent();
        }

        
        public EditarStocks(int cod,string nomb,int stock)
        {
            InitializeComponent();
            txtCod.Text = cod.ToString();
            txtC.Text = stock.ToString();
            txtN.Text = nomb;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nomb = txtN.Text;
            int cant = Int32.Parse(txtC.Text);
            int cod = Int32.Parse(txtCod.Text);
            MessageBox.Show("Datos del producto modificado");
            Dispose(true);
        }

        private void editarStockcs_Load(object sender, EventArgs e)
        {

        }
    }
}

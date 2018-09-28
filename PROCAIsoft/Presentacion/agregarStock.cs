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
        private BindingList<Producto> productos;
        public agregarStock()
        {
            InitializeComponent();
        }
        public agregarStock(BindingList<Producto> p)
        {
            InitializeComponent();
            productos = p;
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Producto p = new Producto();
            p.Nombre=txtN.Text;
            p.Stock = Int32.Parse(txtC.Text);
            productos.Add(p);
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

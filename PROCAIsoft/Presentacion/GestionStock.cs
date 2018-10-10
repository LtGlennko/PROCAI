using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using LogicaNegocio;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmGestStock : Form
    {
        private MerchandisingBL mbl;
        public frmGestStock()
        {
            InitializeComponent();
            mbl = new MerchandisingBL();
        }

        private void dgvStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmGestStock_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            agregarStock agregar1 = new agregarStock();
            //agregar1.Show();
            //System.Console.WriteLine("OKOKOKKK");
            if (DialogResult.OK == agregar1.ShowDialog())
            {
                //dgvStock.AutoGenerateColumns = false;
                dgvStock.DataSource = mbl.listarMerchandising();
                
            }
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int cod = (int)dgvStock.CurrentRow.Cells[0].Value;
            string nombre = dgvStock.CurrentRow.Cells[1].Value.ToString();
            int stock = (int)dgvStock.CurrentRow.Cells[2].Value;
            //dgvStock.CurrentRow.SetValues(cod,nombre,stock);//esta funcion puede simplificar la edicion
            //EditarStockcs editar = new editarStockcs(cod, nombre, stock, productos);
            dgvStock.Rows.RemoveAt(dgvStock.CurrentRow.Index);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que desea eliminar el producto?", "Salir", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                dgvStock.Rows.RemoveAt(dgvStock.CurrentRow.Index);
                MessageBox.Show("Producto Eliminado");
            }
            else if (result == DialogResult.No)
            {

            }
            else if (result == DialogResult.Cancel)
            {

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in dgvStock.Rows)
                foreach (DataGridViewCell celda in fila.Cells)
                    if (txtBuscar.Text.IndexOf(celda.Value.ToString()) >= 0)
                        celda.Style.BackColor = Color.Red;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

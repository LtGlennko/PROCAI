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
using System.Text.RegularExpressions;

namespace Presentacion
{
    public partial class frmGestStock : Form
    {
        private MerchandisingBL mbl;
        public frmGestStock()
        {
            InitializeComponent();
            mbl = new MerchandisingBL();
            dgvStock.DataSource = mbl.listarMerchandising();
            //cambios
            dgvStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvStock.ScrollBars = ScrollBars.Both;
            dgvStock.ForeColor = Color.Black;
            //dgvStock.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
            dgvStock.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            //
            disenio_tabla();
            rbNombre.Checked = true;
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

            //Cambios
            if(dgvStock.CurrentRow == null)
            {
                MessageBox.Show("No se ha seleccionado merchandising a editar", "Error Editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //
            //Poner condicion si es que no se selecciona una fila para editar
            int cod = (int)dgvStock.CurrentRow.Cells[0].Value;
            string nombre = dgvStock.CurrentRow.Cells[1].Value.ToString();
            string descripcion = dgvStock.CurrentRow.Cells[2].Value.ToString();
            int stock = (int)dgvStock.CurrentRow.Cells[3].Value;

            //dgvStock.CurrentRow.SetValues(cod,nombre,stock);//esta funcion puede simplificar la edicion
            //EditarStockcs editar = new editarStockcs(cod, nombre, stock, productos);
            //dgvStock.Rows.RemoveAt(dgvStock.CurrentRow.Index);
            EditarStocks editar = new EditarStocks(cod, nombre, stock,descripcion);
            if(DialogResult.OK == editar.ShowDialog())
            {
                dgvStock.Rows.RemoveAt(dgvStock.CurrentRow.Index);
                dgvStock.DataSource = mbl.listarMerchandising();
            }
            //dgvStock.Rows.RemoveAt(dgvStock.CurrentRow.Index);
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Cambios
            if (dgvStock.CurrentRow == null)
            {
                MessageBox.Show("No se ha seleccionado merchandising a eliminar", "Error Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //
            DialogResult result = MessageBox.Show("¿Seguro que desea eliminar el producto?", "Salir", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                int cod = (int)dgvStock.CurrentRow.Cells[0].Value;
                int stock = (int)dgvStock.CurrentRow.Cells[3].Value;
                if(stock > 0)
                {
                    MessageBox.Show("No se puede eliminar un Merchandising que aún mantiene stock", "Error Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                bool eliminado = mbl.eliminarMerchandising(cod);
                dgvStock.DataSource = mbl.listarMerchandising();
                if(eliminado) MessageBox.Show("Producto Eliminado");
                else MessageBox.Show("Producto no se pudo eliminar");
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
            Regex numeric = new Regex("^[0-9]*$");
            Regex alphaNum = new Regex("^[a-zA-Z0-9 ]*$");
            if (rbNombre.Checked)
            {
                if (!alphaNum.IsMatch(txtBuscar.Text))
                {
                    MessageBox.Show("El nombre debe contener número o letras unicamente", "Nombre de Colegio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                dgvStock.DataSource = mbl.buscarMerchandising(txtBuscar.Text);
            }
            if (rbStock.Checked)
            {
                try
                {
                    int num = Convert.ToInt32(txtBuscar.Text);
                    if (num > 10000)
                    {
                        MessageBox.Show("Debe ingresar número menor a 10000", "Error Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    dgvStock.DataSource = mbl.buscarMerchandisingS(num);
                }
                catch
                {
                    MessageBox.Show("Debe ingresar un número de stock valido", "Error Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
            }
            if (rbCodigo.Checked)
            {
                try
                {
                    int num = Convert.ToInt32(txtBuscar.Text);
                    if (num > 100000)
                    {
                        MessageBox.Show("Debe ingresar número menor a 10000", "Error Codigo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    dgvStock.DataSource = mbl.buscarMerchandisingId(num);
                }
                catch
                {
                    MessageBox.Show("Debe ingresar un código", "Error Codigo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rbNombre_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dgvStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

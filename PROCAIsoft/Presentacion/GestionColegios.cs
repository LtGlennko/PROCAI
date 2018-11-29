using Modelo;
using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Presentacion
{
    public partial class GestCol : Form
    {
        private ColegioBL cbl;
        public GestCol()
        {
            InitializeComponent();
            rbNombre.Checked = true;
            cbl = new ColegioBL();
            dgvCol.DataSource = cbl.listarColegios();
            disenio_tabla();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            AgregarColegio a = new AgregarColegio();

            if (DialogResult.OK == a.ShowDialog())
            {
                //dgvStock.AutoGenerateColumns = false;
                dgvCol.DataSource = cbl.listarColegios();

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que desea eliminar el Colegio?", "Salir", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                int cod = (int)dgvCol.CurrentRow.Cells[0].Value;
                bool eliminado=cbl.eliminarColegio(cod);
                dgvCol.DataSource = cbl.listarColegios();
                if(eliminado) MessageBox.Show("Colegio eliminado");
                else MessageBox.Show("Colegio no se pudo eliminar");
            }
            else if (result == DialogResult.No)
            {

            }
            else if (result == DialogResult.Cancel)
            {

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GestCol_Load(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvCol.CurrentRow == null)
            {
                MessageBox.Show("No se ha seleccionado merchandising a editar", "Error Editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string ruc = dgvCol.CurrentRow.Cells[1].Value.ToString();
            string nombre= dgvCol.CurrentRow.Cells[2].Value.ToString();
            string departamente = dgvCol.CurrentRow.Cells[4].Value.ToString();
            string provincia = dgvCol.CurrentRow.Cells[5].Value.ToString();
            string direccion = dgvCol.CurrentRow.Cells[6].Value.ToString();
            string tipo = dgvCol.CurrentRow.Cells[7].Value.ToString();
            int telf = (int)dgvCol.CurrentRow.Cells[8].Value;

            EditarColegio edc = new EditarColegio(nombre,ruc,departamente,provincia,direccion,telf);
            if (DialogResult.OK == edc.ShowDialog())
            {
                dgvCol.Rows.RemoveAt(dgvCol.CurrentRow.Index);
                dgvCol.DataSource = cbl.listarColegios();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Regex numeric = new Regex("^[0-9]*$");
            Regex alphaNum = new Regex("^[a-zA-Z0-9 ]*$");
            if (rbNombre.Checked) {
                if (!alphaNum.IsMatch(txtBuscar.Text))
                {
                    MessageBox.Show("El nombre debe contener número o letras unicamente", "Error Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                dgvCol.DataSource = cbl.buscarColegio(txtBuscar.Text);
            }
            if (rbRUC.Checked)
            {
                if (txtBuscar.Text.Length > 12 || !numeric.IsMatch(txtBuscar.Text) )
                {
                    MessageBox.Show("RUC no válido, ingrese 12 digitos", "Error Buscar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dgvCol.DataSource = cbl.buscarColegioRUC(txtBuscar.Text);
            }
            if (rbDireccion.Checked)
            {
                if (!alphaNum.IsMatch(txtBuscar.Text))
                {
                    MessageBox.Show("La direccion debe contener número o letras unicamente", "Error Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                dgvCol.DataSource = cbl.buscarColegioDir(txtBuscar.Text);


            }
            if (rbCodigo.Checked)
            {
                try
                {
                    int num = Convert.ToInt32(txtBuscar.Text);
                    if (num > 10000 )
                    {
                        MessageBox.Show("Debe ingresar número menor a 10000", "Error Buscar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    dgvCol.DataSource = cbl.buscarColegioId(num);
                }
                catch
                {
                    MessageBox.Show("Debe ingresar un codigo valido", "Error Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }   
    }
}

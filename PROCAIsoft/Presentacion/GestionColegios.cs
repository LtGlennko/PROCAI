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

namespace Presentacion
{
    public partial class GestCol : Form
    {
        private ColegioBL cbl;
        public GestCol()
        {
            InitializeComponent();
            cbl = new ColegioBL();
            dgvCol.DataSource = cbl.listarColegios();
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
            dgvCol.DataSource = cbl.buscarColegio(txtBuscar.Text);
        }
    }
}

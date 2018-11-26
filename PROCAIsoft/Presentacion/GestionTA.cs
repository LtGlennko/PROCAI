using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using LogicaNegocio;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Presentacion
{
    public partial class GestionTA : Form
    {
        private TipoActividadBL tipoactBL;
        public GestionTA()
        {
            InitializeComponent();
            rbNombre.Checked = true;
            tipoactBL = new TipoActividadBL();
            dgvTA.DataSource = tipoactBL.listarTipoActividad();
            disenio_tabla();
            dgvTA.RowHeadersVisible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarTA agregar = new AgregarTA();
            if (DialogResult.OK == agregar.ShowDialog())
            {
                dgvTA.DataSource = tipoactBL.listarTipoActividad();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int cod = (int)dgvTA.CurrentRow.Cells[0].Value;
            string nombre = dgvTA.CurrentRow.Cells[1].Value.ToString();
            string desc = dgvTA.CurrentRow.Cells[2].Value.ToString();
            EditarTA editar = new EditarTA(cod, nombre, desc);
            if (DialogResult.OK == editar.ShowDialog())
            {
                dgvTA.Rows.RemoveAt(dgvTA.CurrentRow.Index);
                dgvTA.DataSource = tipoactBL.listarTipoActividad();
            }
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
                dgvTA.DataSource = tipoactBL.buscarTipoActivdad(txtBuscar.Text);
            }
            if (rbCodigo.Checked) {
                try
                {
                    int num = Convert.ToInt32(txtBuscar.Text);
                    if (num > 10000)
                    {
                        MessageBox.Show("Debe ingresar número menor a 10000", "Error Buscar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    dgvTA.DataSource = tipoactBL.buscarTipoActivdadId(num);
                }
                catch
                {
                    MessageBox.Show("Debe ingresar un codigo valido", "Error Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que desea eliminar el Tipo de Actividad?", "Salir", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                int cod = (int)dgvTA.CurrentRow.Cells[0].Value;
                bool eliminado = tipoactBL.eliminarTipoActividad(cod);
                dgvTA.DataSource = tipoactBL.listarTipoActividad();
                if (eliminado) MessageBox.Show("Tipo de Actividad Eliminado", "Eliminar Tipo de Actividad", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("No se pudo eliminar el Tipo de Actividad", "Error Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (result == DialogResult.No)
            {

            }
            else if (result == DialogResult.Cancel)
            {

            }
        }

        private void rbNombre_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

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

namespace Presentacion
{
    public partial class GestionTA : Form
    {
        private TipoActividadBL tipoactBL;
        public GestionTA()
        {
            InitializeComponent();
            tipoactBL = new TipoActividadBL();
            dgvTA.DataSource = tipoactBL.listarTipoActividad();
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
            dgvTA.DataSource = tipoactBL.buscarTipoActivdad(txtBuscar.Text);
        }
    }
}

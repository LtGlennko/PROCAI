﻿using Modelo;
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
            DialogResult result = MessageBox.Show("¿Seguro que desea eliminar el producto?", "Salir", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                dgvCol.Rows.RemoveAt(dgvCol.CurrentRow.Index);
                MessageBox.Show("Producto Eliminado");
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
    }
}

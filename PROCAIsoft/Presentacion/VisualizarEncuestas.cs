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
    public partial class frmRegYeditEncuestas : Form
    {
        public frmRegYeditEncuestas(int flag)
        {
            //btnRegistrar.Enabled = true;
            //btnModificar.Enabled = true;
            InitializeComponent();
            if (flag == 0)
            {
                btnModificar.Enabled = false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Encuesta registrada con éxito");
        }

        private void btnRetresar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDetalleEncuesta DE = new frmDetalleEncuesta();
            if (DE.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void frmRegYeditEncuestas_Load(object sender, EventArgs e)
        {

        }
    }
}

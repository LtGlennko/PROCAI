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
    public partial class frmVisualizarPostulantes : Form
    {

        public frmVisualizarPostulantes()
        {
            InitializeComponent();

            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarPostulanteUorientador EP = new AgregarPostulanteUorientador('P');
            if (EP.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}

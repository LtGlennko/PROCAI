using LogicaNegocio;
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
        private EscolarBL escolarBL;

        public frmVisualizarPostulantes()
        {
            InitializeComponent();

            dgvPostulantes.AutoGenerateColumns = false;
            dgvPostulantes.RowHeadersVisible = false;

            escolarBL = new EscolarBL();
            dgvPostulantes.DataSource = escolarBL.listarEscolares();
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarPostulanteUorientador EP = new AgregarPostulanteUorientador('P', 0, 0, 0, 0);
            if (EP.ShowDialog() == DialogResult.OK)
            {

            }
            dgvPostulantes.DataSource = escolarBL.listarEscolares();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Escolar esc = (Escolar)dgvPostulantes.CurrentRow.DataBoundItem;
            AgregarPostulanteUorientador EP = new AgregarPostulanteUorientador('P', esc.IdEscolar1, esc.Colegio.IdColegio1, esc.TelefonoApoderado, esc.GradoInt);
            if (EP.ShowDialog() == DialogResult.OK)
            {

            }
            dgvPostulantes.DataSource = escolarBL.listarEscolares();
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

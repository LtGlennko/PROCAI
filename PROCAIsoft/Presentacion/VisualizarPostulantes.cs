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
        private BindingList<Postulante> postulantes;

        public frmVisualizarPostulantes()
        {
            InitializeComponent();
            postulantes = new BindingList<Postulante>();

            Postulante p1 = null;
            Colegio c1 = new Colegio();
            List<Colegio> lc1 = new List<Colegio>();
            lc1.Add(c1);
            p1 = new Postulante(1, 78412569, "Sandro", "Cera", "Lara", "correo_@gmail.com", 745896523,
                'M', 0, Convert.ToDateTime("01/01/2018"), null, 0, lc1, "5°",7452563, 0, null);

            Postulante p2 = null;
            Colegio c2 = new Colegio();
            List<Colegio> lc2 = new List<Colegio>();
            lc2.Add(c2);

            p2 = new Postulante(2, 78412369, "Martha", "Marquez", "Lore", "martha_@gmail.com", 745896123,
                'F', 0, Convert.ToDateTime("01/01/2018"), null, 0, lc2, "4°", 7345620, 0, null);

            postulantes.Add(p1);
            postulantes.Add(p2);

            dgv.DataSource = postulantes;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarPostulante ap = new AgregarPostulante(postulantes);
            if (ap.ShowDialog() == DialogResult.OK)
            {
                dgv.Show();
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
            EditarPostulante EP = new EditarPostulante();
            if (EP.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}

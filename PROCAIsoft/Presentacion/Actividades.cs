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
    public partial class Actividades : Form
    {
        private DateTime date;

        public Actividades()
        {
            InitializeComponent();
        }

        public Actividades(BindingList<Actividad> a, DateTime d)
        {
            InitializeComponent();
            date = d;
            dgvAct.DataSource = a;
        }

        private void Actividades_Load(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

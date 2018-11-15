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
    public partial class GestionOrientadores : Form
    {
        public GestionOrientadores()
        {
            InitializeComponent();
            disenio_tabla();
        }

        private void nuevoOrientadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaNuevoOrientador VA = new VentanaNuevoOrientador();
            if (VA.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void GestionOrientadores_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

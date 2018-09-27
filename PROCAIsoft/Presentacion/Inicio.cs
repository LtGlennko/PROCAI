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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Login log = new Login();
            //this.Visible = false;
            //if(log.ShowDialog() == DialogResult.OK)
            //{

            //}
            this.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //InicioExterno ie = new InicioExterno();
            this.Visible = false;
            //if (ie.ShowDialog() == DialogResult.OK)
            //{

            //}
            //this.Visible = true;
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }
    }
}

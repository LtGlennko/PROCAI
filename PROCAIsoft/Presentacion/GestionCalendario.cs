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
    public partial class GestionCal : Form
    {
        private BindingList<Actividad> actividades;
        public GestionCal()
        {
            InitializeComponent();
            actividades = new BindingList<Actividad>();
        }

        private void GestionCal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime d = DateTime.Parse(dtp.Text);
            //Actividad a3 = new Actividad("AEA", "AEA2");
            Actividades a = new Actividades(actividades,d);
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}

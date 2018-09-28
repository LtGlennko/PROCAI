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
    public partial class GeneradorRepEncuestas : Form
    {
        public GeneradorRepEncuestas()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Reporte R = new Reporte();
            R.Visible = true;
        }

        private void GeneradorRepEncuestas_Load(object sender, EventArgs e)
        {

        }
    }
}

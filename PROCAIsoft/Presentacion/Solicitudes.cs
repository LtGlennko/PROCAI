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
    public partial class frmSolicitudes : Form
    {
        public frmSolicitudes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Validado", "System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //dataGridView1.Rows.Add();
            //dataGridView1[0, 5].ValueType() = "Validado";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InfoSolicitud IS = new InfoSolicitud();
            IS.Show();
        }

        private void frmSolicitudes_Load(object sender, EventArgs e)
        {

        }
    }
}

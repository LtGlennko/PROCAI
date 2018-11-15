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
    public partial class frmProcesoAdm : Form
    {
        private BindingList<ProcesoAdmision> listaProcesos = new BindingList<ProcesoAdmision>();
        public frmProcesoAdm()
        {
            InitializeComponent();

            llenarDGV();
            
        }
        public void llenarDGV() {
            ProcesoAdmisionBL PABL = new ProcesoAdmisionBL();
            if (listaProcesos != null) this.listaProcesos = new BindingList<ProcesoAdmision>();
            PABL.listarProcesosAdmision(listaProcesos);
            
            dgvProcesoAdmin.DataSource = null;
            dgvProcesoAdmin.DataSource = listaProcesos;
            disenio_tabla();
        }
        private void disenio_tabla() {
            dgvProcesoAdmin.RowsDefaultCellStyle.BackColor = Color.White;
            dgvProcesoAdmin.Font = new Font("Century Gothic", 8 , FontStyle.Regular);
            dgvProcesoAdmin.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 11, FontStyle.Bold);
            dgvProcesoAdmin.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvProcesoAdmin.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dgvProcesoAdmin.EnableHeadersVisualStyles = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ProcesoAdmision PA = null;
            
            VentanaNuevoProcesoAdmision VNPA = new VentanaNuevoProcesoAdmision(this);
            if (VNPA.ShowDialog() == DialogResult.OK)
            {

            }
            //llenarDGV();

        }

        private object tostring(int i)
        {
            throw new NotImplementedException();
        }

        private void listadoProcesosAdmision_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        
    }
}

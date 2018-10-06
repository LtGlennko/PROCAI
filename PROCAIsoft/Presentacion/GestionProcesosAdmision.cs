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
        //List<ProcesoAdmision> procesos = new List<ProcesoAdmision>();
        public frmProcesoAdm()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaNuevoProcesoAdmision VNPA = new VentanaNuevoProcesoAdmision();
            VNPA.Show();
            int i = 0;
            //foreach (ProcesoAdmision pa in VNPA.ProcesosAdmision) {
            //    dgvPA.Rows.Add();
            //    dgvPA[i, 0].Value = tostring(i);
            //    dgvPA[i, 1].Value = pa.Descripcion;
            //    dgvPA[i, 2].Value = tostring(pa.CantidadVacantes);
            //    dgvPA[i, 3].Value = pa.Descripcion;

            //}

        }

        private object tostring(int i)
        {
            throw new NotImplementedException();
        }

        private void listadoProcesosAdmision_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

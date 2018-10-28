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
    public partial class frmSolicitudes : Form
    {
        BindingList<SolicitudInscripcionActividad> listaSIA = new BindingList<SolicitudInscripcionActividad>();
        private int idSeleccionado =0;
        private SolicitudInscripcionActividad SIAseleccionado=null;
        public frmSolicitudes()
        {
            InitializeComponent();
            SolicitudInscripcionBL SIBL = new SolicitudInscripcionBL();
            if (SIBL.listarSolicitudInscripcionActividad(listaSIA)) {
                this.dgv_Solicitudes.DataSource = null;
                this.dgv_Solicitudes.DataSource = listaSIA;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Validado", "System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
        }

        

        private void frmSolicitudes_Load(object sender, EventArgs e)
        {

        }

        private void dgv_Solicitudes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgv_Solicitudes.Rows[index];
            this.idSeleccionado = Int32.Parse(selectedRow.Cells[0].Value.ToString());
            foreach (SolicitudInscripcionActividad SI_rec in listaSIA) {
                if (SI_rec.IdSolicitudInscripcion1 == this.idSeleccionado) {
                    this.SIAseleccionado = SI_rec;
                    break;
                }
            }

        }

        private void btnDertalles_Click(object sender, EventArgs e)
        {
            if(SIAseleccionado==null)
                this.SIAseleccionado = listaSIA[0];

            InfoSolicitud IS = new InfoSolicitud(this.SIAseleccionado);
            
            IS.Show();
        }
    }
}

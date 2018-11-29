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
        private EscogerMerchandising em;
        BindingList<SolicitudInscripcionActividad> listaSIA = new BindingList<SolicitudInscripcionActividad>();
        private int idSeleccionado =0;
        private SolicitudInscripcionActividad SIAseleccionado=null;
        public frmSolicitudes()
        {
            InitializeComponent();
            SolicitudInscripcionBL SIBL = new SolicitudInscripcionBL();
            listarActividades();
        }
        private bool listarActividades() {
            SolicitudInscripcionBL SIBL = new SolicitudInscripcionBL();
            listaSIA = new BindingList<SolicitudInscripcionActividad>();
            bool success = SIBL.listarSolicitudInscripcionActividad(listaSIA);
            if (success) {
                this.dgv_Solicitudes.DataSource = null;
                this.dgv_Solicitudes.DataSource = listaSIA;
                this.disenio_tabla();
            }
            return success;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SolicitudInscripcionBL SIABL = new SolicitudInscripcionBL();

            bool success =false;
            if (SIAseleccionado != null)
            {
                EscogerMerchandising emm = new EscogerMerchandising(this);
                emm.Visible = true;
                //int id = 0;
                while (emm.index==-1) {
                }

                SIAseleccionado.Actividad.MaterialRepartido.IdMerchandising1 = emm.getIdM();


                success = SIABL.validarSolicitudInscripcionActividad(SIAseleccionado, 1);
                if (success)
                {

                    MessageBox.Show("Validado", "System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    listarActividades();
                }
                else
                {
                    MessageBox.Show("Bad conection", "System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else {
                MessageBox.Show("No hay Solicitudes por validar", "System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           
            
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
            if (SIAseleccionado == null)
            {
                MessageBox.Show("No hay items seleccionados", "System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                InfoSolicitud IS = new InfoSolicitud(this.SIAseleccionado);
                
                IS.Show();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SolicitudInscripcionBL SIABL = new SolicitudInscripcionBL();
            bool success = false;
            if (SIAseleccionado != null)
            {
                
                success = SIABL.validarSolicitudInscripcionActividad(this.SIAseleccionado, 0);
                if (success)
                {
                    MessageBox.Show("Rechazado", "System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    listarActividades();
                }
                else
                {
                    MessageBox.Show("Bad conection", "System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("No hay Solicitudes por rechazar", "System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }
    }
    
}

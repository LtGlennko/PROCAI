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
    public partial class EscogerMerchandising : Form
    {
        private MerchandisingBL mbl;
        BindingList<Merchandising> lm;
        Form parent;
        public int index = -1;
        private SolicitudInscripcionActividad SIAseleccionado;
        public EscogerMerchandising(frmSolicitudes p, SolicitudInscripcionActividad SIASIAseleccionad)
        {
            InitializeComponent();
            this.SIAseleccionado = SIASIAseleccionad;
            this.parent = p;
            parent.Enabled = false;
            mbl = new MerchandisingBL();
            lm = new BindingList<Merchandising>();
            lm = mbl.listarMerchandising();
            cmbx_tipoProceso.DataSource = lm;
            
        }

        public int getIdM() {
            int index = cmbx_tipoProceso.SelectedIndex;
            int i = 0;
            foreach (Merchandising M in lm) {
                if (i == index)
                    return M.IdMerchandising1;
                i++;
            }
            return 0;
            
        }

        private void EscogerMerchandising_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Enabled = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            parent.Enabled = true;
            this.Dispose();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {

            SolicitudInscripcionBL SIABL = new SolicitudInscripcionBL();

            bool success = false;
            if (SIAseleccionado != null)
            {
                
                SIAseleccionado.Actividad.MaterialRepartido= new Merchandising();
                SIAseleccionado.Actividad.MaterialRepartido.IdMerchandising1 = getIdM();


                success = SIABL.validarSolicitudInscripcionActividad(SIAseleccionado, 1);
                if (success)
                {

                    MessageBox.Show("Validado", "System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                }
                else
                {
                    MessageBox.Show("Bad conection", "System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("No hay Solicitudes por validar", "System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            parent.Enabled = true;
            this.Dispose();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            parent.Enabled = true;
            this.Dispose();
        }
    }
}

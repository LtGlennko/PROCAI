using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using LogicaNegocio;
using AccesoDatos;

namespace Presentacion
{
    public partial class SolicitarColegio : Form
    {
        private RegionBL regionBL;
        private DistritoBL distritoBL;
        private ProvinciaBL provinciaBL;
        private BindingList<SolicitudColegio> solicitudes;
        private SolicitudColegioDA solicitudColegioDA;
        public SolicitarColegio()
        {
            InitializeComponent();
            solicitudes = new BindingList<SolicitudColegio>();
            regionBL = new RegionBL();
            provinciaBL = new ProvinciaBL();
            distritoBL = new DistritoBL();
            solicitudColegioDA = new SolicitudColegioDA();
            cboDep.DisplayMember = "Nombre";
            cboDep.ValueMember = "Id";
            cboDep.DataSource = regionBL.listarRegion();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debe ingresar el nombre del colegio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (((cboDep.Text == "") || (txtPais.Text == "")))
            {
                MessageBox.Show("Debe ingresar un pais y un departamento", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SolicitudColegio sol = new SolicitudColegio(txtNombre.Text, txtTelefono.Text, txtObservacion.Text, txtPais.Text, cboDep.Text, cbProvincia.Text);
            solicitudColegioDA.registrarSolicitudColegio(sol);
        }

        private void SolicitudColegio_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cboDep_SelectedIndexChanged(object sender, EventArgs e)
        {
            string p = cboDep.SelectedValue.ToString();
            cbProvincia.DisplayMember = "Nombre";
            cbProvincia.ValueMember = "Id";
            cbProvincia.DataSource = provinciaBL.listarPronvincia(p);
        }

        private void txtTelefono_KeyUp(object sender, KeyEventArgs e)
        {
            int caracter = e.KeyValue;

            if (caracter > 57 || caracter < 48)
            {
                this.txtTelefono.Text = "";
            }
            else
            {
                this.txtTelefono.Text = "";
            }
        }
    }
}

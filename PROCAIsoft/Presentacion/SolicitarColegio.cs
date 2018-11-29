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

namespace Presentacion
{
    public partial class SolicitarColegio : Form
    {
        private RegionBL regionBL;
        private DistritoBL distritoBL;
        private ProvinciaBL provinciaBL;
        private BindingList<SolicitudColegio> solicitudes;

        public SolicitarColegio()
        {
            InitializeComponent();
            solicitudes = new BindingList<SolicitudColegio>();
            regionBL = new RegionBL();
            provinciaBL = new ProvinciaBL();
            distritoBL = new DistritoBL();
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
            try
            {
                long nRUC = long.Parse(txtRUC.Text);
                if(nRUC < 10000000000 || nRUC > 99999999999)
                {
                    MessageBox.Show("El RUC debe ser de 11 dígitos");
                    return;
                }
                if (!solicitudYaRegistrada(nRUC))
                {
                    SolicitudColegio sol = new SolicitudColegio(nRUC, txtNombre.Text, txtTelefono.Text, txtObservacion.Text);
                    solicitudes.Add(sol);
                    MessageBox.Show("Solicitud enviada con éxito");
                }
                else
                {
                    MessageBox.Show("No puede registrar el mismo RUC más de una vez cada 12 horas");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("El RUC ingresado no es valido");
            }
            
                
        }

        private void SolicitudColegio_Load(object sender, EventArgs e)
        {

        }

        public bool solicitudYaRegistrada(long nRUC)
        {
            foreach(SolicitudColegio sol in this.solicitudes)
            {
                if (sol.Ruc == nRUC)
                    return true;
            }
            return false;
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
    }
}

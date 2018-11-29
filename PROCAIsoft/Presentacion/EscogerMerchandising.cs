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
        public EscogerMerchandising(Form p)
        {
            InitializeComponent();
            this.parent = p;
            parent.Enabled = false;
            mbl = new MerchandisingBL();
            lm = new BindingList<Merchandising>();
            lm = mbl.listarMerchandising();
            cmbx_tipoProceso.DataSource = lm;
        }

        public int getIdM() {
            int index = cmbx_tipoProceso.SelectedIndex;
            return lm.ElementAt<Merchandising>(index).IdMerchandising1;
            
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

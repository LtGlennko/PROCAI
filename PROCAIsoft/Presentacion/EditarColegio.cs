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
using System.Text.RegularExpressions;

namespace Presentacion
{
    public partial class EditarColegio : Form
    {
        private ColegioBL colbl;
        private RegionBL regionBL;
        private DistritoBL distritoBL;
        private ProvinciaBL provinciaBL;
        public EditarColegio()
        {
            InitializeComponent();
            colbl = new ColegioBL();
        }

        public EditarColegio(int cod,string nombre, string ruc, string dep, string prov, string direccion, int telf)
        {
            InitializeComponent();
            colbl = new ColegioBL();
            txtN.Text = nombre;
            txtRuc.Text = ruc;
            txtid.Text = cod.ToString();
            cboDep.SelectedValue = dep;
            cbProvincia.SelectedValue = prov;
            txtDir.Text = direccion;
            txtTelf.Text = telf.ToString();
            cboTipoCol.SelectedValue = cboTipoCol.Items[0];
            regionBL = new RegionBL();
            provinciaBL = new ProvinciaBL();
            distritoBL = new DistritoBL();
            cboDep.DisplayMember = "Nombre";
            cboDep.ValueMember = "Id";
            cboDep.DataSource = regionBL.listarRegion();
        }
        private void lbl_titulo_Click(object sender, EventArgs e)
        {

        }

        private void txtN_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nom = txtN.Text;
            string pai = txtPais.Text;
            string dep = cboDep.Text;
            string pro = cbProvincia.Text;
            int id = Int32.Parse(txtid.Text);
            string dir = txtDir.Text;
            string tipStr = cboTipoCol.Text;
            TipoColegio tip;
            if (tipStr == "Estatal") tip = TipoColegio.Estatal;
            else tip = TipoColegio.Particular;
            string ruc = txtRuc.Text;
            int tel;
            Regex alphaNum = new Regex("^[a-zA-Z0-9 ]*$");
            Regex numeric = new Regex("^[0-9]*$");

            if (nom == "")
            {
                MessageBox.Show("Debe ingresar el nombre del colegio", "Nombre de Colegio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!alphaNum.IsMatch(nom))
            {
                MessageBox.Show("El nombre debe contener número o letras unicamente", "Nombre de Colegio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (pai == "")
            {
                MessageBox.Show("Debe ingresar el pais", "País", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (dep == "")
            {
                MessageBox.Show("Debe ingresar el departamento", "Departamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (pro == "")
            {
                MessageBox.Show("Debe ingresar la provincia", "Provincia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            if (dir == "")
            {
                MessageBox.Show("Debe ingresar la dirección", "Dirección", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (tipStr == "")
            {
                MessageBox.Show("Debe ingresar el tipo de colegio", "Tipo de Colegio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            /*try
            {
                tel = Int32.Parse(txtTelf.Text);
            }catch (Exception)
            {
                MessageBox.Show("El telefono debe ser un numero de 7 digitos");
                return;
            }*/
            if (txtRuc.Text == "")
            {
                MessageBox.Show("Debe ingresar un RUC", "RUC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!numeric.IsMatch(ruc) || txtRuc.Text.Length < 11)
            {
                MessageBox.Show("Debe ingresar un número de 11 dígitos", "RUC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTelf.Text == "")
            {
                MessageBox.Show("Debe ingresar un teléfono", "Teléfono", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!Int32.TryParse(txtTelf.Text, out tel) || txtTelf.Text.Length < 7)
            {
                MessageBox.Show("Debe ingresar un número de 7 dígitos", "Teléfono", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Colegio col = new Colegio(id,ruc, nom, pai, dep, pro, dir, tip, tel);
            bool registrado = colbl.actualizarColegio(col);
            if (registrado) MessageBox.Show("Colegio actualizado con exito", "Editar Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Error al actualizar", "Editar Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.DialogResult = DialogResult.OK;
        }
        

        private void cboDep_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string p = cboDep.SelectedValue.ToString();
            cbProvincia.DisplayMember = "Nombre";
            cbProvincia.ValueMember = "Id";
            cbProvincia.DataSource = provinciaBL.listarPronvincia(p);
        }

        private void label5_Click(object sender, EventArgs e)
        {
                
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }
    }
}

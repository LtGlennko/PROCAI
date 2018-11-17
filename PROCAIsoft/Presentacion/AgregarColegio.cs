using Modelo;
using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Presentacion
{
    public partial class AgregarColegio : Form
    {
        
        private ColegioBL colegioBL;
        public AgregarColegio()
        {
           
            InitializeComponent();
            colegioBL = new ColegioBL();
        }
        
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nom = txtN.Text;
            string pai = txtPais.Text;
            string dep = cboDep.Text;
            string pro = cbProvincia.Text;
            string dis = cbDistrito.Text;
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
            if (dis == "")
            {
                MessageBox.Show("Debe ingresar el distrito", "Dirección", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            string nro = txtTelf.Text;
            Colegio col = new Colegio(ruc, nom, pai, dep, pro, dir, tip, tel);
            bool registrado = colegioBL.registrarColegio(col);
            if (registrado) MessageBox.Show("Colegio registrado con exito", "Registro Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Error al registrar", "Registro Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
        }

        private void AgregarColegio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }

        private void txtTipo_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboPais_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRuc_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }
    }
}

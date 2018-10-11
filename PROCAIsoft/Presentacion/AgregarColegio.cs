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
            string pai = txtP.Text;
            string dep = txtD.Text;
            string pro = txtPro.Text;
            string dis = txtDis.Text;
            string dir = txtDir.Text;
            string tipStr = txtTipo.Text;
            TipoColegio tip;
            if (tipStr == "Estatal") tip = TipoColegio.Estatal;
            else tip = TipoColegio.Particular;
            string ruc = txtRuc.Text;
            int tel;
            try
            {
                tel = Int32.Parse(txtTelf.Text);
            }catch (Exception)
            {
                MessageBox.Show("El telefono debe ser un numero de 7 digitos");
                return;
            }
            string nro = txtTelf.Text;
            Colegio col = new Colegio(ruc, nom, pai, dep, pro, dir, tip, tel);
            bool registrado = colegioBL.registrarColegio(col);
            if(registrado) MessageBox.Show("Escuela registrada con exito");
            else MessageBox.Show("Error al registrar");
            this.DialogResult = DialogResult.OK;
        }

        private void AgregarColegio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }
    }
}

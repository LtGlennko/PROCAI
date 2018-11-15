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
    public partial class AgregarTA : Form
    {
        private TipoActividadBL tabl;
        public AgregarTA()
        {
            InitializeComponent();
            tabl = new TipoActividadBL();
        }

        private void AgregarTA_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNomb.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar nombre");
                return;
            }
            if (txtDesc.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar descripcion");
                return;
            }
            string nombre = txtNomb.Text;
            string descripcion = txtDesc.Text;
            TipoActividad ta = new TipoActividad();
            ta.Nombre = nombre;
            ta.Descripcion = descripcion;
            bool registar=tabl.registarTipoActividad(ta);
            if(registar) MessageBox.Show("Escuela registrada con exito");
            else MessageBox.Show("Error al registrar");
            this.DialogResult = DialogResult.OK;
        }

        private void txtNomb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

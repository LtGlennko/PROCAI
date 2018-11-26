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
            Regex numeric = new Regex("^[0-9]*$");
            Regex alphaNum = new Regex("^[a-zA-Z0-9 ]*$");

            if (txtNomb.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar nombre", "Error Tipo Actividad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtNomb.Text.Length > 5 || txtNomb.Text.Length < 30)
            {
                MessageBox.Show("Tamaño de nombre inválido ", "Error Tipo Actividad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!alphaNum.IsMatch(txtNomb.Text))
            {
                MessageBox.Show("El nombre debe contener número o letras unicamente", "Nombre de Tipo de Atividad", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtDesc.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar descripcion", "Error Tipo Actividad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtDesc.Text.Length > 50)
            {
                MessageBox.Show("Debe ingresar descripcion menor a 50 caracteres", "Error Tipo Actividad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!alphaNum.IsMatch(txtDesc.Text))
            {
                MessageBox.Show("La descripcion debe contener número o letras unicamente", "Descripcion de Tipo de Actividad", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string nombre = txtNomb.Text;
            string descripcion = txtDesc.Text;
            TipoActividad ta = new TipoActividad();
            ta.Nombre = nombre;
            ta.Descripcion = descripcion;
            bool registar=tabl.registarTipoActividad(ta);
            if(registar) MessageBox.Show("Escuela registrada con exito" ,"Registrar Tipo de Actividad",MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Error al registrar" ,"Registrar Tipo de Actividad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.DialogResult = DialogResult.OK;
        }

        private void txtNomb_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }
    }
}

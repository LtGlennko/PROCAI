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
    public partial class EditarPostulante : Form
    {
        Persona personaBus;
        public EditarPostulante()
        {
            InitializeComponent();
            bloquearBotones();
        }

        private void EditarPostulante_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void txtCelular_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cambios guardados con éxito");
            if(cboGrado.Text == "")
            {
                MessageBox.Show("Debe seleccionar un grado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtTelf.Text == "")
            {
                MessageBox.Show("Debe ingresar un valor para el numero de apoderado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboColegio.Text == "")
            {
                MessageBox.Show("Debe seleccionar un colegio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnBuscarPersona_Click(object sender, EventArgs e)
        {
            BuscarPersona bp = new BuscarPersona();
            if (bp.ShowDialog() == DialogResult.OK)
            {
                personaBus = bp.PersonaSel;
            }
            if(personaBus != null)
            {
                //Se completan los campos predeterminados
                txtDNI.Text = personaBus.DNI1;
                txtNombres.Text = personaBus.Nombres;
                txtApPat.Text = personaBus.ApellidoPaterno;
                txtApMat.Text = personaBus.ApellidoMaterno;
                txtCelular.Text = personaBus.Celular.ToString();
                TipoSexo s = personaBus.Sexo;
                if (s == TipoSexo.Hombre) cboSexo.Text = "Hombre";
                else if (s == TipoSexo.Mujer) cboSexo.Text = "Mujer";
                else cboSexo.Text = "Personalizado";
                txtCorreoE.Text = personaBus.CorreoElectronico;                
            }
        }

        private void bloquearBotones()
        {
            txtDNI.Enabled = false;
            txtNombres.Enabled = false;
            txtApPat.Enabled = false;
            txtApMat.Enabled = false;
            txtCelular.Enabled = false;
            cboSexo.Enabled = false;
            txtCorreoE.Enabled = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void limpiarCampos()
        {
            txtDNI.Text = "";
            txtNombres.Text = "";
            txtApPat.Text = "";
            txtApMat.Text = "";
            txtCelular.Text = "";
            cboSexo.Text = "";
            txtCorreoE.Text = "";
        }
    }
}

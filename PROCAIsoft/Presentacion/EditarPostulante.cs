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
    public partial class EditarPostulante : Form
    {
        private Persona personaBus;
        private ColegioBL colegioBL;
        private int idPersonaSel;
        public EditarPostulante()
        {
            InitializeComponent();
            colegioBL = new ColegioBL();

            cboColegio.DataSource = colegioBL.listarColegios();
            cboColegio.ValueMember = "IdColegio1";
            cboColegio.DisplayMember = "Nombre";
            bloquearBotones();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(txtDNI.Text == "")
            {
                MessageBox.Show("Debe seleccionar una persona registrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboGrado.Text == "")
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
            if ((txtUsuario.Text == "") || (txtContraseña.Text == ""))
            {
                MessageBox.Show("Debe ingresar un usuario y contraseña para la nueva cuenta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            TipoSexo sexo;
            if (cboSexo.Text == "Hombre") sexo = TipoSexo.Hombre;
            else if (cboSexo.Text == "Mujer") sexo = TipoSexo.Mujer;
            else sexo = TipoSexo.Personalizado;
            TipoGrado grado;
            if (cboGrado.Text == "Tercero") grado = TipoGrado.Tercero;
            else if (cboGrado.Text == "Cuarto") grado = TipoGrado.Cuarto;
            else grado = TipoGrado.Quinto;
            Escolar escolar = new Escolar(txtDNI.Text, txtNombres.Text, txtApPat.Text, txtApMat.Text, Int32.Parse(txtCelular.Text), sexo, txtCorreoE.Text, DateTime.Today, 1, grado, Int32.Parse(txtTelf.Text));
            escolar.IdPersona1 = escolar.IdUsuario1 = escolar.IdUsuario1 = idPersonaSel;
            Cuenta cuenta = new Cuenta(DateTime.MinValue, txtUsuario.Text, txtContraseña.Text);
            escolar.CuentaUsuario = cuenta;
            //Registrar nuevo escolar
            MessageBox.Show("Cambios guardados con éxito");
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
                idPersonaSel = personaBus.IdPersona1;
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
            limpiarCampos();
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
            cboGrado.Text = "";
            txtTelf.Text = "";
            cboColegio.Text = "";
            txtUsuario.Text = "";
            txtContraseña.Text = "";
        }

        private void ptrVisible_MouseDown(object sender, MouseEventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = false;
        }

        private void ptrVisible_MouseLeave(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = true;
        }

        private void txtTelf_KeyUp(object sender, KeyEventArgs e)
        {
            int caracter = e.KeyValue;

            if (caracter > 57 || caracter < 48)
            {
                this.txtTelf.Text = "";
            }
        }
    }
}

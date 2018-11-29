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
    public partial class AgregarPostulanteUorientador : Form
    {
        private Persona personaBus;
        private ColegioBL colegioBL;
        private EscolarBL escolarBL;
        private CuentaBL cuentaBL;
        private PersonaBL personaBL;
        private int idPersonaSel;
        private char tipoUsu;
        private int idUsuModif;
        //El parametro idUsu es mayor a 0 si es que se presionó el botón modificar
        //Los parametros tlfApoderado y grado son 0 si no se quiere editar un postulante
        public AgregarPostulanteUorientador(char tipoUsuario, int idUsu, int idColegio, int tlfApoderado, int grado)
        {
            InitializeComponent();

            tipoUsu = tipoUsuario;
            idUsuModif = idUsu;
            
            colegioBL = new ColegioBL();
            escolarBL = new EscolarBL();
            cuentaBL = new CuentaBL();
            personaBL = new PersonaBL();

            cboColegio.DataSource = colegioBL.listarColegios();
            cboColegio.ValueMember = "IdColegio1";
            cboColegio.DisplayMember = "Nombre";
            bloquearBotonesPersona();

            if(tipoUsu == 'O')
            {
                txtTelf.Visible = false;
                cboGrado.Visible = false;
                lblTelf.Visible = false;
                lblGrado.Visible = false;
                lbl_titulo.Text = "Datos de Orientador";
            }
            //Si el idUsuModif es mayor a 0 significa que se seleccionó Modificar
            if (idUsuModif > 0)
            {
                //Buscamos la persona para autocompletar los campos
                BindingList<Persona> personas = personaBL.listarPersonas();
                Persona personaAmostrar = null;
                foreach (Persona p in personas)
                {
                    if (p.IdPersona1 == idUsuModif)
                        personaAmostrar = p;
                }
                if (personaAmostrar != null)
                {
                    completarCamposPersona(personaAmostrar);
                    cboColegio.SelectedValue = idColegio;
                    if(tipoUsu == 'P' && tlfApoderado > 0 && grado > 0)
                    {
                        txtTelf.Text = tlfApoderado.ToString();
                        if (grado == 3)
                            cboGrado.Text = "Tercero";
                        else if (grado == 4)
                            cboGrado.Text = "Cuarto";
                        else
                            cboGrado.Text = "Quinto";
                    }
                }
                txtUsuario.Enabled = false;
                txtContraseña.Enabled = false;
                btnBuscarPersona.Enabled = false;
            }
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
            if (((txtUsuario.Text == "") || (txtContraseña.Text == "")) && idPersonaSel==0)
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
            escolar.IdPersona1 = escolar.IdUsuario1 = escolar.IdEscolar1 = idPersonaSel;
            //Asignar cuenta
            Cuenta cuenta = new Cuenta(DateTime.MinValue, txtUsuario.Text, txtContraseña.Text);
            escolar.CuentaUsuario = cuenta;
            //Asignar colegio
            escolar.Colegio = (Colegio)cboColegio.SelectedItem;
            //Registrar nuevo escolar
            if (cuentaBL.existeNombreUsuario(cuenta))
            {
                MessageBox.Show("El nombre de usuario ya está siendo en uso", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (escolarBL.registrarEscolar(escolar) == 0)
            {
                MessageBox.Show("Error al registrar el escolar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Escolar registrado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Si se quiere editar un escolar u orientador, no se registra ni actualiza la cuenta
            //Si el idUsuModif es mayor a 0 significa que se seleccionó Modificar
            if (idUsuModif > 0) return;
            if (!cuentaBL.registrarCuenta(idPersonaSel, cuenta))
            {
                MessageBox.Show("Error al registrar la cuenta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
                completarCamposPersona(personaBus);
            }
        }

        //Autocompletar campos con persona
        private void completarCamposPersona(Persona P)
        {
            txtDNI.Text = P.DNI1;
            txtNombres.Text = P.Nombres;
            txtApPat.Text = P.ApellidoPaterno;
            txtApMat.Text = P.ApellidoMaterno;
            txtCelular.Text = P.Celular.ToString();
            TipoSexo s = P.Sexo;
            if (s == TipoSexo.Hombre) cboSexo.Text = "Hombre";
            else if (s == TipoSexo.Mujer) cboSexo.Text = "Mujer";
            else cboSexo.Text = "Personalizado";
            txtCorreoE.Text = P.CorreoElectronico;
            idPersonaSel = P.IdPersona1;
        }


        private void bloquearBotonesPersona()
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

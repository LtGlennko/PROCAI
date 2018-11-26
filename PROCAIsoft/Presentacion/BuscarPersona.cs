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
    public partial class BuscarPersona : Form
    {
        private PersonaBL personaBL;
        private Persona personaSel;

        public Persona PersonaSel { get => personaSel; set => personaSel = value; }

        public BuscarPersona()
        {
            InitializeComponent();
            personaBL = new PersonaBL();
            dgvPersonas.AutoGenerateColumns = false;
            dgvPersonas.RowHeadersVisible = false;
            dgvPersonas.DataSource = personaBL.listarPersonas();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                personaSel = (Persona)dgvPersonas.CurrentRow.DataBoundItem;
                this.DialogResult = DialogResult.OK;
            }
            catch
            {
                MessageBox.Show("Tiene que selecionar una persona", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuscarPersona_Load(object sender, EventArgs e)
        {

        }
    }
}

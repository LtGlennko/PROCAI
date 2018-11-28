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
    public partial class GestionOrientadores : Form
    {
        OrientadorBL orientadorBL;
        public GestionOrientadores()
        {
            InitializeComponent();

            dgvOrientadores.AutoGenerateColumns = false;
            dgvOrientadores.RowHeadersVisible = false;

            orientadorBL = new OrientadorBL();
            dgvOrientadores.DataSource = orientadorBL.listarOrientadores();

            //AQUI DEBES PODER VER LA LISTA DE ORIENTADORES, SI NO EXISTE, AL AGREGAR BUSCO ENTRE TODOS LOS USUARIOS DISPONIBLES QUE NO TIENEN CUENTA

            // WDF??? TU debes poner esa wada , tu dijiste que harias esta ventana, 
            //pero para acelerar solo listare lo del nul y demas lo haces tu

            disenio_tabla();
        }

        private void nuevoOrientadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void GestionOrientadores_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarPostulanteUorientador EP = new AgregarPostulanteUorientador('O', 0, 0, 0, 0);
            if (EP.ShowDialog() == DialogResult.OK)
            {

            }
            dgvOrientadores.DataSource = orientadorBL.listarOrientadores();
        }

        private void dgvPostulantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

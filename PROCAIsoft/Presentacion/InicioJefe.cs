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
    public partial class InicioJefe : Form
    {
        BindingList<Usuario> usuarios;
        public InicioJefe(BindingList<Usuario> usuarios, Usuario u)
        {
            InitializeComponent();
            lblNombreUsu.Text += u.NombreUsuario;
            this.usuarios = usuarios;
        }

        private void btnGestionarPermisos_Click(object sender, EventArgs e)
        {
            Gestionar_permisos f = new Gestionar_permisos(usuarios);
            f.StartPosition = FormStartPosition.CenterScreen;
            this.Visible = false;
            if (f.ShowDialog() == DialogResult.OK)
            {

            }
            this.Visible = true;
        }

        private void InicioJefe_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnGenerarRepEncuestas_Click(object sender, EventArgs e)
        {
            GeneradorRepEncuestas GE = new GeneradorRepEncuestas();            
            GE.StartPosition = FormStartPosition.CenterScreen;
            this.Visible = false;
            if (GE.ShowDialog() == DialogResult.OK)
            {

            }
            this.Visible = true;
        }
    }
}

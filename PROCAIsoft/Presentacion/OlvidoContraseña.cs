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
   
    public partial class OlvidoContraseña : Form
    {
       


        public OlvidoContraseña()
        {
            InitializeComponent();
        }

        private void OlvidoContraseña_Load(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if(txtCorreo.Text == "")
            {
                MessageBox.Show("No se ha ingresado un correo");
            }
            else if(!txtCorreo.Text.Contains("@"))
            {
                MessageBox.Show("El correo ingresado no es válido");
            }
            else
            {
                MessageBox.Show("Enlace enviado exitosamente");
                Dispose();
            }
            
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}

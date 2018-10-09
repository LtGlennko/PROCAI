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
    public partial class Gestionar_permisos : Form
    {
        BindingList<Usuario> usuarios;
        public Gestionar_permisos()
        {
            UsuarioBL usuarioBL = new UsuarioBL();
            usuarios = usuarioBL.listarUsuarios();
            List<Usuario> sortedUsu = usuarios.OrderBy(x => x.FechaCreacion).ToList();
            sortedUsu.Reverse();
            InitializeComponent();
            dvgUsuarios.AutoGenerateColumns = false;
            dvgUsuarios.DataSource = sortedUsu;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Dispose();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Los cambios han sido guardados con éxito");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int nNivel = (int)nudNivel.Value;
                Usuario usuSel = (Usuario)dvgUsuarios.CurrentRow.DataBoundItem;
                if(nNivel == 5 && usuSel.NivelPermiso < 3)
                {
                    MessageBox.Show("Solo un ejecutivo o un administrativo pueden ser jefes");
                    return;
                }
                usuSel.NivelPermiso = nNivel;
                string username = ((Usuario)dvgUsuarios.CurrentRow.DataBoundItem).NombreCuenta;
                MessageBox.Show("Nivel de permiso de usuario '" + username + "' cambiado a " + nNivel);
            }
            catch (Exception)
            {
                MessageBox.Show("No se puedo cambiar el nivel de permiso");
            }
            
        }

        private void dvgUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void nudNivel_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

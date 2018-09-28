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
        public Gestionar_permisos(BindingList<Usuario> usuarios)
        {
            List<Usuario> sortedUsu = usuarios.OrderBy(x => x.FechaCreacion).ToList();
            sortedUsu.Reverse();
            InitializeComponent();
            dvgUsuarios.DataSource = sortedUsu;
        }

        private void Gestionar_permisos_Load(object sender, EventArgs e)
        {

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
                int nNivel = Int32.Parse(txtNivel.Text);
                if (nNivel <= 0 || nNivel > 5)
                {
                    MessageBox.Show("El valor seleccionado no está en el rango posible");
                    return;
                }
                ((Usuario)dvgUsuarios.CurrentRow.DataBoundItem).NivelPermiso = nNivel;
            }
            catch (Exception)
            {
                MessageBox.Show("El valor ingresado debe ser un número");
            }
            
        }

        private void dvgUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

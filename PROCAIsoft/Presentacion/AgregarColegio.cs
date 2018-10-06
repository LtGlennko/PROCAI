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
    public partial class AgregarColegio : Form
    {
        private BindingList<Colegio> colegios;
        public AgregarColegio()
        {
            colegios = new BindingList<Colegio>();
            InitializeComponent();
        }
        public AgregarColegio(BindingList<Colegio> col)
        {
            InitializeComponent();
            colegios = col;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
        }

        private void AgregarColegio_Load(object sender, EventArgs e)
        {

        }
    }
}

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
            Colegio col = new Colegio();
            col.Nombre = txtN.Text;
            col.Pais = txtP.Text;
            col.Departamento = txtD.Text;
            col.Provincia = txtPro.Text;
            col.Distrito = txtDis.Text;
            col.Ruc = txtRuc.Text;
            col.Telefono = Int32.Parse(txtTelf.Text);
            col.Direccion = txtDir.Text;
            col.Tipo = txtTipo.Text;
            colegios.Add(col);
            txtN.Text = String.Empty;
            txtP.Text = String.Empty;
            txtD.Text = String.Empty;
            txtPro.Text = String.Empty;
            txtDir.Text = String.Empty;
            txtTelf.Text = String.Empty;
            txtRuc.Text = String.Empty;
            MessageBox.Show("Producto registrado");
        }

        private void AgregarColegio_Load(object sender, EventArgs e)
        {

        }
    }
}

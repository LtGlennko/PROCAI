using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocio;
using AccesoDatos;
using Modelo;
namespace Presentacion
{
    public partial class BuscarGrupo : Form
    {
        private GrupoBL grupoBL;
        private GrupoEncuestas grupoEncuestasSel;

        public GrupoEncuestas getGrupoSel()  //para dar la informaciones al precediente formulario
        {
            return grupoEncuestasSel;
        }

        public BuscarGrupo()
        {
            grupoBL = new GrupoBL();
            InitializeComponent();
            dgvGrupos.AutoGenerateColumns = false;
            dgvGrupos.DataSource = grupoBL.listarGrupos();
            disenio_tabla();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                grupoEncuestasSel = (GrupoEncuestas)dgvGrupos.CurrentRow.DataBoundItem;//COPIAR 
                this.DialogResult = DialogResult.OK;
            }
            catch
            {
                MessageBox.Show("Tiene que selecionar a un grupo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }
    }
}

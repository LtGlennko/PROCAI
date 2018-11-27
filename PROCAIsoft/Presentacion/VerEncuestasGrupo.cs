using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using LogicaNegocio;


namespace Presentacion
{
    public partial class VerEncuestasGrupo : Form
    {

        public VerEncuestasGrupo(BindingList<Encuesta> encuestasDeGrupoSel)
            
        {
            InitializeComponent();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource= encuestasDeGrupoSel;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

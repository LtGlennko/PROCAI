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
namespace Presentacion
{
    public partial class BuscarGrupo : Form
    {
        private GrupoBL grupoBL;
        public BuscarGrupo()
        {
            InitializeComponent();
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "ID del grupo";
            dataGridView1.Columns[1].Name = "Tipo de actividad";
            dataGridView1.Columns[2].Name = "Fecha programada";
            dataGridView1.Columns[3].Name = "Colegio";
            dataGridView1.Columns[4].Name = "Guia";
            grupoBL = new GrupoBL();
            dataGridView1.DataSource = grupoBL.listarGrupo();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}

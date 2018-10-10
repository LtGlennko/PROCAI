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

        public GrupoEncuestas getGrupoSel()
        {
            return grupoEncuestasSel;
        }

        public BuscarGrupo()
        {
            grupoBL = new GrupoBL();
            InitializeComponent();
            dgvGrupos.AutoGenerateColumns = false;
            
            dgvGrupos.DataSource = grupoBL.listarGrupos();
            //dataGridView1.Columns[0].Name = "ID del grupo";
            //dataGridView1.Columns[1].Name = "Fecha programada";
            //dataGridView1.Columns[2].Name = "Colegio";
            //dataGridView1.Columns[3].Name = "Tipo de actividad";
            //dataGridView1.Columns[4].Name = "Nombre del Guia";
            //dataGridView1.Columns[5].Name = "Apellido materno del Guia";
            //dataGridView1.Columns[6].Name = "Apellido paterno del Guia"; //NO FUNCIONA
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvGrupos.SelectedRows.Count != 1)
            {
                MessageBox.Show("Se debe seleccionar un grupo");
            }

            else
            {
                grupoEncuestasSel = (GrupoEncuestas)dgvGrupos.CurrentRow.DataBoundItem;//COPIAR 
                this.DialogResult = DialogResult.OK;
            }
            
        }
    }
}

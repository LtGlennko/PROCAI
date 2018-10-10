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
    public partial class frmRegYeditEncuestas : Form
    {
        private Encuesta encuestaCreada;
        private GrupoEncuestas grupoBuscado;
        private Pregunta preg1;
        private Pregunta preg2;
        private Pregunta preg3;
        private Pregunta preg4;
        public frmRegYeditEncuestas(int flag)
        {
            //btnRegistrar.Enabled = true;
            //btnModificar.Enabled = true;
            encuestaCreada = new Encuesta();
            InitializeComponent();
            if (flag == 0)
            {
                btnModificar.Enabled = false;
            }
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //encuestaCreada.setGrupo(grupoBuscado);
            agregarCalificacionSeleccionada(encuestaCreada, grpP1, preg1);
            agregarCalificacionSeleccionada(encuestaCreada, grpP2, preg2);
            agregarCalificacionSeleccionada(encuestaCreada, grpP3, preg3);
            agregarCalificacionSeleccionada(encuestaCreada, grpP4, preg4);
            
            MessageBox.Show("Encuesta registrada con éxito");
        }

        private void agregarCalificacionSeleccionada(Encuesta encuesta, GroupBox grupo, Pregunta preg)
        {
            RadioButton btn = grupo.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);
            modificaYagregaCalif(btn, encuesta, preg, "1");
            modificaYagregaCalif(btn, encuesta, preg, "2");
            modificaYagregaCalif(btn, encuesta, preg, "3");
            modificaYagregaCalif(btn, encuesta, preg, "4");
        }

        private void modificaYagregaCalif(RadioButton btn, Encuesta encuesta, Pregunta preg, string nroStr)
        {
            if ((btn.Text).Equals(nroStr))
            {
                CalificacionPXE calif = new CalificacionPXE(Int32.Parse(nroStr));
                calif.setPregunta(preg);
                encuesta.addCalificacionPorEncuesta(calif);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDetalleEncuesta DE = new frmDetalleEncuesta();
            if (DE.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void frmRegYeditEncuestas_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            BuscarGrupo bg = new BuscarGrupo();
            bg.Visible = true;
        }
    }
}

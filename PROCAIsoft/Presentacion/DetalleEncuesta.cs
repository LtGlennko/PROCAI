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

namespace Presentacion
{
    public partial class frmDetalleEncuesta : Form
    {
        public frmDetalleEncuesta(Encuesta E)
        {
            InitializeComponent();

            //Se pone el id del grupo
            labelRespuestaGrupo.Text = E.GrupoPerteneciente.TipoYnombreActividad;

            //Se pone la fecha
            int dia = E.FechaProgramada.Day;
            int mes = E.FechaProgramada.Month;
            int anho = E.FechaProgramada.Year;

            labelRespuestaFecha.Text = dia.ToString() +"/"+ mes.ToString() + "/" + anho.ToString();

            //Se ponen la calificaciones
            labelRespuestaPregunta1.Text = E.CalificacionP1.ToString();
            labelRespuestaPregunta2.Text = E.CalificacionP2.ToString();
            labelRespuestaPregunta3.Text = E.CalificacionP3.ToString();
            labelRespuestaPregunta4.Text = E.CalificacionP4.ToString();

            //Se pone el detalle de las preguntas
            labelPregunta1.Text = E.CalificacionesPorEncuesta[0].Pregunta.Enunciado.ToString();
            labelPregunta2.Text = E.CalificacionesPorEncuesta[1].Pregunta.Enunciado.ToString();
            labelPregunta3.Text = E.CalificacionesPorEncuesta[2].Pregunta.Enunciado.ToString();
            labelPregunta4.Text = E.CalificacionesPorEncuesta[3].Pregunta.Enunciado.ToString();

        }

        private void btnRetresar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void frmDetalleEncuesta_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

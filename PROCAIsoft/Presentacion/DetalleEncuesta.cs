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
            labelRespuestaGrupo.Text = E.IdGrupoPerteneciente.ToString();

            //Se pone la fecha
            labelRespuestaFecha.Text = E.FechaProgramada.ToString();

            //Se ponen la calificaciones
            labelRespuestaPregunta1.Text = E.CalificacionP1.ToString();
            labelRespuestaPregunta2.Text = E.CalificacionP2.ToString();
            labelRespuestaPregunta3.Text = E.CalificacionP3.ToString();
            labelRespuestaPregunta4.Text = E.CalificacionP4.ToString();

            //Se pone el detalle de las preguntas
            //HACERLO


        }

        private void btnRetresar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void frmDetalleEncuesta_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class CalificacionPXE
    {
        protected static int i = 0;
        private int IdCalificacionPXE;
        private int calificacion;
        private Encuesta encuesta;
        private Pregunta pregunta;

        public CalificacionPXE(int calificacion)
        {
            IdCalificacionPXE = ++i;
            this.calificacion = calificacion;
        }

        public int IdCalificacionPXE1 { get => IdCalificacionPXE; set => IdCalificacionPXE = value; }
        public int Calificacion { get => calificacion; set => calificacion = value; }
        public Encuesta Encuesta { get => encuesta; set => encuesta = value; }
        public Pregunta Pregunta { get => pregunta; set => pregunta = value; }
        public void setEncuesta(Encuesta enc)
        {
            this.encuesta = enc;
            enc.CalificacionesPorEncuesta.Add(this);
        }
        public void setPregunta(Pregunta pre)
        {
            this.pregunta = pre;
            pre.CalificacionesPorPregunta.Add(this);
        }
    }
}

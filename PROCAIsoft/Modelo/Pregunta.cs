using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Pregunta
    {
        protected static int i = 0;
        private int IdPregunta;
        private string enunciado;
        private TipoActividad tipoActividad;
        private List<CalificacionPXE> calificacionesPorPregunta;

        public Pregunta(string enunciado)
        {
            IdPregunta = ++i;
            this.enunciado = enunciado;
            this.calificacionesPorPregunta = new List<CalificacionPXE>();
        }

        public int IdPregunta1 { get => IdPregunta; set => IdPregunta = value; }
        public string Enunciado { get => enunciado; set => enunciado = value; }
        public TipoActividad TipoActividad { get => tipoActividad; set => tipoActividad = value; }
        public List<CalificacionPXE> CalificacionesPorPregunta { get => calificacionesPorPregunta; set => calificacionesPorPregunta = value; }
        public void setTipoActividad(TipoActividad tip)
        {
            this.tipoActividad = tip;
            tip.Preguntas.Add(this);
        }
        public void addCalificacionPorPregunta(CalificacionPXE cal)
        {
            this.calificacionesPorPregunta.Add(cal);
            cal.Pregunta = this;
        }
    }
}

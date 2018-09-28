using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    class Encuesta
    {
        private static int i = 0;
        private int IdEncuesta;
        private GrupoEncuestas grupoPerteneciente;
        private List<CalificacionPXE> calificacionesPorPregunta;
        private Guia digitador;

        public Encuesta(GrupoEncuestas grupoPerteneciente, Guia digitador)
        {
            this.IdEncuesta = ++i;
            this.grupoPerteneciente = grupoPerteneciente;
            this.digitador = digitador;
            calificacionesPorPregunta = new List<CalificacionPXE>();
        }

        public int IdEncuesta1 { get => IdEncuesta; set => IdEncuesta = value; }
        public GrupoEncuestas GrupoPerteneciente { get => grupoPerteneciente; set => grupoPerteneciente = value; }
        public List<CalificacionPXE> CalificacionesPorPregunta { get => calificacionesPorPregunta; set => calificacionesPorPregunta = value; }
        public Guia Digitador { get => digitador; set => digitador = value; }
        public void AddcCalificacionPorPregunta(CalificacionPXE pxe)
        {
            calificacionesPorPregunta.Add(pxe);
        }
    }
}

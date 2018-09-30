using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Encuesta
    {
        private static int i = 0;
        private int IdEncuesta;
        private GrupoEncuestas grupoPerteneciente;
        private List<CalificacionPXE> calificacionesPorEncuesta;
        private Guia digitador;

        public Encuesta()
        {
            IdEncuesta = ++i;
            this.calificacionesPorEncuesta = new List<CalificacionPXE>();
        }
        public int IdEncuesta1 { get => IdEncuesta; set => IdEncuesta = value; }
        public GrupoEncuestas GrupoPerteneciente { get => grupoPerteneciente; set => grupoPerteneciente = value; }
        public List<CalificacionPXE> CalificacionesPorEncuesta { get => calificacionesPorEncuesta; set => calificacionesPorEncuesta = value; }
        public Guia Digitador { get => digitador; set => digitador = value; }
        public void setGrupo(GrupoEncuestas gru)
        {
            this.grupoPerteneciente = gru;
            gru.ListaDeEncuestas.Add(this);
        }
        public void setDigitador(Guia gui)
        {
            this.digitador = gui;
            gui.EncuestasDigitadas.Add(this);
        }
        public void addCalificacionPorEncuesta(CalificacionPXE cal)
        {
            this.calificacionesPorEncuesta.Add(cal);
            cal.Encuesta = this;
        }
    }
}

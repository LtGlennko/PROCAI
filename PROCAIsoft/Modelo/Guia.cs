using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Guia : TrabajadorOCAI
    {
        protected static int i = 0;
        private int IdGuia;
        private char tipoGuia;
        private string licencia;
        private List<GrupoEncuestas> encuestasDondeFueEvaluado;
        private List<GrupoEncuestas> encuestasDigitadas;

        public Guia(DateTime fechaCreacion, int nivelPermiso, DateTime fechaIngreso, int estadoTrabajador, char tipoGuia, string licencia): base (fechaCreacion, nivelPermiso, fechaIngreso, estadoTrabajador)
        {
            this.IdGuia = ++i;
            this.TipoGuia = tipoGuia;
            this.Licencia = licencia;
        }

        public char TipoGuia { get => tipoGuia; set => tipoGuia = value; }
        public string Licencia { get => licencia; set => licencia = value; }
        internal List<GrupoEncuestas> EncuestasDondeFueEvaluado { get => encuestasDondeFueEvaluado; set => encuestasDondeFueEvaluado = value; }
        internal List<GrupoEncuestas> EncuestasDigitadas { get => encuestasDigitadas; set => encuestasDigitadas = value; }
    }
}

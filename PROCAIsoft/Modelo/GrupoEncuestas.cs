using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class GrupoEncuestas
    {
        protected static int i = 0;
        private int IdGrupoEncuestas;
        private Colegio colegio;
        private Actividad actividad;        
        private Guia guiaEvaluado;
        private BindingList<Encuesta> listaDeEncuestas;

        public GrupoEncuestas()
        {
            IdGrupoEncuestas = ++i;
            this.listaDeEncuestas = new BindingList<Encuesta>();
        }

        public int IdGrupoEncuestas1 { get => IdGrupoEncuestas; set => IdGrupoEncuestas = value; }
        public Colegio Colegio { get => colegio; set => colegio = value; }
        public Actividad Actividad { get => actividad; set => actividad = value; }
        public string TipoYnombreActividad { get => actividad.TipoActividad.Nombre + ": " + actividad.TipoActividad.Descripcion; }
        public int CantAlumnos { get => Actividad.CantEstudiantes;  }
        public DateTime FechaProgramada { get => actividad.FechaProgramada; }
        public Guia GuiaEvaluado { get => guiaEvaluado; set => guiaEvaluado = value; }
        public BindingList<Encuesta> ListaDeEncuestas { get => listaDeEncuestas; set => listaDeEncuestas = value; }
        public void setColegio(Colegio col)
        {
            this.colegio = col;
            col.EncuestasLlenadas.Add(this);
        }
        public void setActividad(Actividad act)
        {
            this.actividad = act;
            act.GruposDeEncuestas.Add(this);
        }
        public void setGuiaEvaluado(Guia gui)
        {
            this.guiaEvaluado = gui;
            gui.GruposDondeFueEvaluado.Add(this);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class TipoActividad
    {
        private static int i = 0;
        private int IdTipoActividad;
        private string nombre;
        private string descripcion;
        private BindingList<Actividad> listaActividades;
        private BindingList<Pregunta> preguntas;

        public TipoActividad(string nombre, string descripcion)
        {
            IdTipoActividad = i++;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.listaActividades = new BindingList<Actividad>();
            this.preguntas = new BindingList<Pregunta>();
        }

        public int IdTipoActividad1 { get => IdTipoActividad; set => IdTipoActividad = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public BindingList<Actividad> ListaActividades { get => listaActividades; set => listaActividades = value; }
        public BindingList<Pregunta> Preguntas { get => preguntas; set => preguntas = value; }
        public void addActividad(Actividad act)
        {
            this.listaActividades.Add(act);
            act.TipoActividad = this;
        }
        public void addPregunta(Pregunta pre)
        {
            this.preguntas.Add(pre);
            pre.TipoActividad = this;
        }
    }
}

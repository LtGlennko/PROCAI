using System;
using System.Collections.Generic;
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
        private List<Actividad> listaActividades;
        private List<Pregunta> preguntas;

        public TipoActividad(string nombre, string descripcion)
        {
            IdTipoActividad = ++i;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.listaActividades = new List<Actividad>();
            this.preguntas = new List<Pregunta>();
        }

        public int IdTipoActividad1 { get => IdTipoActividad; set => IdTipoActividad = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public List<Actividad> ListaActividades { get => listaActividades; set => listaActividades = value; }
        public List<Pregunta> Preguntas { get => preguntas; set => preguntas = value; }
    }
}

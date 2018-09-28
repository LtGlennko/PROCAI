using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    class TipoActividad
    {
        private static int i = 0;
        private int IdTipoActividad;
        private string nombre;
        private string descripcion;

        public TipoActividad()
        {
            i++;
            IdTipoActividad = i;
        }
        public TipoActividad(string nombre, string descripcion)
        {
            IdTipoActividad1 = i++;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
        }

        public int IdTipoActividad1 { get => IdTipoActividad; set => IdTipoActividad = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}

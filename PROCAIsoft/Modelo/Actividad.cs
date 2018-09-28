using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    
    public class Actividad
    {
        private static int i;
        private int idActividad;
        private string nombre;
        private string desc;

        public Actividad()
        {
            i++;
            idActividad = i;
        }
        public Actividad( string nombre, string desc)
        {
            i++;
            IdActividad =i;
            this.nombre = nombre;
            this.desc = desc;
        }

        public int IdActividad { get => idActividad; set => idActividad = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Desc { get => desc; set => desc = value; }
    }
}

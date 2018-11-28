using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Provincia
    {
        private int id;
        private string nombre;
        private string idregion;

        public Provincia()
        {

        }
        public Provincia(int id, string nombre, string idregion)
        {
            this.id = id;
            this.nombre = nombre;
            this.Idregion = idregion;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Idregion { get => idregion; set => idregion = value; }
    }
}

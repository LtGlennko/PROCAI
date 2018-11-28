using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Distrito
    {
        private int id;
        private string nombre;
        private string idregion;
        private string idprovincia;

        public Distrito()
        {

        }
        public Distrito(int id, string nombre, string idregion, string idprovincia)
        {
            this.id = id;
            this.nombre = nombre;
            this.Idregion = idregion;
            this.Idprovincia = idprovincia;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Idregion { get => idregion; set => idregion = value; }
        public string Idprovincia { get => idprovincia; set => idprovincia = value; }
    }
}

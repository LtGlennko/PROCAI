using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Merchandising
    {
        //protected static int i = 0;
        private int IdMerchandising;
        private string nombre;
        private string descripcion;
        private int stock;
        private List<Actividad> actividades;

        public Merchandising(int id,string nombre, string descripcion, int stock)
        {
            IdMerchandising = id;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.stock = stock;
            this.actividades = new List<Actividad>();
        }

        public int IdMerchandising1 { get => IdMerchandising; set => IdMerchandising = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Stock { get => stock; set => stock = value; }
        public List<Actividad> Actividades { get => actividades; set => actividades = value; }
        public void addActividad(Actividad act)
        {
            this.actividades.Add(act);
            act.MaterialRepartido = this;
        }
    }
}

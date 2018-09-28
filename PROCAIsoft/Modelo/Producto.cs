using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class  Producto
    {
        private static int i = 0;
        private int idproducto;
        private string nombre;
        private int stock;

        public Producto()
        {
            i++;
            idproducto = i;
        }
        public Producto(int id, string nombre, int stock)
        {
            idproducto = id;
            this.nombre = nombre;
            this.stock = stock;
        }

        public int Codigo { get => idproducto; set => idproducto = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Stock { get => stock; set => stock = value; }
    }
}

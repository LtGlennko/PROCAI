using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class DetalleMerchandizing
    {
        private int IdDetalleMerchandizing;
        private int cantidad;
        private Material material;

        public DetalleMerchandizing() { }

        public DetalleMerchandizing(int IdDetalleMerchandizing, int cantidad,
            Material material)
        {
            this.IdDetalleMerchandizing = IdDetalleMerchandizing;
            this.cantidad = cantidad;
            this.material = material;
        }

        public int getIdDetalleMerchandizing() { return this.IdDetalleMerchandizing; }
        public int getCantidad() { return this.cantidad; }
        public Material getMaterial() { return material; }

        public void setIdDetalleMerchandizing(int IdDetalleMerchandizing)
        {
            this.IdDetalleMerchandizing = IdDetalleMerchandizing;
        }

        public void setCantidad(int cantidad)
        {
            this.cantidad = cantidad;
        }

        public void setMaterial(Material material)
        {
            this.material = material;
        }
    }
}
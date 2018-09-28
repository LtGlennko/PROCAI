using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Material
    {
        private string nombre;
        private int IdMaterial;
        private string descripcion;
        private int stock;
        private List<DetalleMerchandizing> detallesDondeFueIncluido;

        public Material()
        {
            this.detallesDondeFueIncluido = new List<DetalleMerchandizing>();
            this.stock = 0;
        }

        public Material(string nombre, int IdMaterial, string descripcion)
        {
            this.nombre = nombre;
            this.IdMaterial = IdMaterial;
            this.descripcion = descripcion;
            this.detallesDondeFueIncluido = new List<DetalleMerchandizing>();
            this.stock = 0;
        }

        public string getNombre() { return nombre; }
        public int getIdMaterial() { return IdMaterial; }
        public string getDescripcion() { return descripcion; }
        public int getStock() { return stock; }

        public void setDescripcion(string descripcion)
        {
            this.descripcion = descripcion;
        }

        public void setStock(int stock)
        {
            this.stock = stock;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void setIdMaterial(int IdMaterial)
        {
            this.IdMaterial = IdMaterial;
        }

        public void addDetallesDondeFueIncluido(DetalleMerchandizing DetM)
        {
            this.detallesDondeFueIncluido.Add(DetM);
        }
    }
}
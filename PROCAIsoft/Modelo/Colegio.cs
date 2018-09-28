using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Colegio
    {
        protected static int i = 0;
        private int IdColegio;
        private string nombre;
        private string pais;
        private string departamento;
        private string provincia;
        private string distrito;
        private string direccion;
        private string tipo;
        private string ruc;
        private int telefono;

        public Colegio()
        {
            i++;
            IdColegio = i;
        }
        public Colegio(string nombre, string pais, string departamento, string provincia, string distrito, string direccion, string tipo, string ruc, int telefono)
        {
            this.nombre = nombre;
            this.pais = pais;
            this.departamento = departamento;
            this.provincia = provincia;
            this.distrito = distrito;
            this.direccion = direccion;
            this.tipo = tipo;
            this.ruc = ruc;
            this.telefono = telefono;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Pais { get => pais; set => pais = value; }
        public string Departamento { get => departamento; set => departamento = value; }
        public string Provincia { get => provincia; set => provincia = value; }
        public string Distrito { get => distrito; set => distrito = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Ruc { get => ruc; set => ruc = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public int IdColegio1 { get => IdColegio; set => IdColegio = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class SolicitudColegio
    {
        private static int i = 0;
        private int idSolicitud;
        private string nombre;
        private string telefono;
        private string observacion;
        private string pais;
        private string departamento;
        private string provincia;

        public SolicitudColegio(string _nombre, string _telefono, string _observacion, string _pais, string _departamento, string _provincia)
        {
            nombre= _nombre;
            telefono= _telefono;
            observacion= _observacion;
            pais= _pais;
            departamento= _departamento;
            provincia= _provincia;
        }
        public static int I { get => i; set => i = value; }
        public int IdSolicitud { get => idSolicitud; set => idSolicitud = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Observacion { get => observacion; set => observacion = value; }
        public string Pais { get => pais; set => pais = value; }
        public string Departamento { get => departamento; set => departamento = value; }
        public string Provincia { get => provincia; set => provincia = value; }
    }
}

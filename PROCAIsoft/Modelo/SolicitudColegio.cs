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
        private long ruc;
        private string nombre;
        private string telefono;
        private string observacion;

        public SolicitudColegio(long rUC)
        {
            IdSolicitud = ++i;
            this.Ruc = rUC;
        }

        public SolicitudColegio(long rUC, string nombre, string telefono, string observacion)
        {
            IdSolicitud = ++i;
            this.Ruc = rUC;
            this.Nombre = nombre;
            this.Telefono = telefono;
            this.Observacion = observacion;
        }



        public int IdSolicitud { get => idSolicitud; set => idSolicitud = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Observacion { get => observacion; set => observacion = value; }
        public long Ruc { get => ruc; set => ruc = value; }
    }
}

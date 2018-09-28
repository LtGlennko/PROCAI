using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class TrabajadorOCAI : Usuario
    {
        protected static int i = 0;
        private int IdTrabajadorOCAI;
        private DateTime fechaIngreso;
        private int estadoTrabajador;

        public TrabajadorOCAI(DateTime fechaCreacion, int nivelPermiso, DateTime fechaIngreso, int estadoTrabajador) : base(fechaCreacion, nivelPermiso)
        {
            this.IdTrabajadorOCAI1 = ++i;
            this.FechaIngreso = fechaIngreso;
            this.EstadoTrabajador = estadoTrabajador;
        }

        public int IdTrabajadorOCAI1 { get => IdTrabajadorOCAI; set => IdTrabajadorOCAI = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public int EstadoTrabajador { get => estadoTrabajador; set => estadoTrabajador = value; }
    }
}

using AccesoDatos;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class TrabajadorOCAIBL
    {
        private TrabajadorOCAIDA trabajadorOCAIDA;
        public TrabajadorOCAIBL()
        {
            trabajadorOCAIDA = new TrabajadorOCAIDA();
        }

        public TrabajadorOCAI crearTrabajadorOCAI(Usuario u)
        {
            return trabajadorOCAIDA.crearTrabajadorOCAI(u);
        }
    }
}

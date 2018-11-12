using AccesoDatos;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class ActividadBL
    {
        private ActividadDA actividadDA;
        public ActividadBL()
        {
            actividadDA = new ActividadDA();
        }
        public BindingList<Actividad> listarActividades()
        {
            return actividadDA.listarActividades();
        }
    }
}

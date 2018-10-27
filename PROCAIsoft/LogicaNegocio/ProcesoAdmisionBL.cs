using Modelo;
using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace LogicaNegocio
{
    public class ProcesoAdmisionBL
    {
        public bool insertarProcesoAdmision(ProcesoAdmision PA)
        {
            bool success = false;
            ProcesoAdmisionDA PADA = new ProcesoAdmisionDA();

            success = PADA.insertarProcesoAdmision(PA);

            return success;
        }

        public bool listarProcesosAdmision(BindingList<ProcesoAdmision> listaPA)
        {
            bool success = false;
            ProcesoAdmisionDA PADA = new ProcesoAdmisionDA();

            success = PADA.listarProcesosAdmision(listaPA);

            return success;
        }
    }
}
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
    public class TipoProcesoAdmisionBL
    {
        public bool listarTipoProcesos(BindingList<TipoProcesoAdmision> listaTPA) {
            bool success = false;
            TipoProcesoAdmisionDA TPADA = new TipoProcesoAdmisionDA();

            success = TPADA.listarTipoProcesos(listaTPA);

            return success;
        }
    }
}

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
    public class SolicitudColegioBL
    {
        SolicitudColegioDA solicitudColegioDA;
        public SolicitudColegioBL()
        {
            solicitudColegioDA = new SolicitudColegioDA();
        }
        public bool registrarSolicitudColegio(SolicitudColegio S)
        {
            return solicitudColegioDA.registrarSolicitudColegio(S);
        }

        public BindingList<SolicitudColegio> listaSolicitudesColegios()
        {
            return solicitudColegioDA.listaSolicitudesColegios();
        }
    }
}

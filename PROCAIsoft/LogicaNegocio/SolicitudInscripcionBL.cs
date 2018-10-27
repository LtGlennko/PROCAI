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
    public class SolicitudInscripcionBL
    {
        public bool listarSolicitudInscripcionActividad(BindingList<SolicitudInscripcionActividad> listaSIA)
        {
            bool success = false;
            SolicitudInscripcionDA SIADA = new SolicitudInscripcionDA();

            success = SIADA.listarSolicitudInscripcionActividad(listaSIA);

            return success;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using AccesoDatos;
using System.ComponentModel;

namespace LogicaNegocio
{
    public class TipoActividadBL
    {
        private TipoActividadDA taDA;

        public TipoActividadBL()
        {
            taDA = new TipoActividadDA();
        }

        public BindingList<TipoActividad> listarTipoActividad()
        {
            return taDA.listarTipoActividades();
        }

        public BindingList<TipoActividad> buscarTipoActivdad(string pista)
        {
            return taDA.buscarTA( pista);
        }
        public bool registarTipoActividad(TipoActividad ta)
        {
            return taDA.registrarTipoActividad(ta);
        }

        public bool actualizarTipoActividad(TipoActividad ta)
        {
            return taDA.actualizarTipoActividad(ta);
        }
    }
}

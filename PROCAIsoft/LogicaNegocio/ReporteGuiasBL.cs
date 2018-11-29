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
    public class ReporteGuiasBL
    {
        private ReporteGuiasDA reporteGuiasDA;
        public ReporteGuiasBL()
        {
            reporteGuiasDA = new ReporteGuiasDA();
        }
        public BindingList<ResultadoGuia> listarResultadosGuia(DateTime fechaIni, DateTime fechaFin)
        {
            return reporteGuiasDA.listarResultadosGuia(fechaIni, fechaFin);
        }
    }
}

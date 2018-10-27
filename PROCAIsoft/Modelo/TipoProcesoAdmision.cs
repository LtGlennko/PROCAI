using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class TipoProcesoAdmision
    {
        protected static int i = 0;
        private int IdTipoProceso;
        private string nombreTipoProceso;
        private string descripcion;
        private List<ProcesoAdmision> procesosCreados;
        public TipoProcesoAdmision() { }
        public TipoProcesoAdmision(string nombreTipoProceso, string descripcion)
        {
            IdTipoProceso = ++i;
            this.nombreTipoProceso = nombreTipoProceso;
            this.descripcion = descripcion;
            this.procesosCreados = new List<ProcesoAdmision>();
        }

        public int IdTipoProceso1 { get => IdTipoProceso; set => IdTipoProceso = value; }
        public string NombreTipoProceso { get => nombreTipoProceso; set => nombreTipoProceso = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public List<ProcesoAdmision> ProcesosCreados { get => procesosCreados; set => procesosCreados = value; }
        public void addProceso(ProcesoAdmision pro)
        {
            this.procesosCreados.Add(pro);
            pro.TipoProceso = this;
        }
    }
}

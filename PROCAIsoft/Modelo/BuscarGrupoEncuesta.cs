using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    // UTILIZADA POR LA VENTANA BUSCARGRUPO
    public class BuscarGrupoEncuesta
    {
        private int IdGrupo;
        private String tipoActividad;
        private String colegio;
        private DateTime fecha;
        private String guia_nombre;
        private String guia_apellidom;
        private String guia_apellidop;

        public BuscarGrupoEncuesta()
        {

        }
        public BuscarGrupoEncuesta(int idGrupo, string tipoActividad, string colegio, DateTime fecha, string guia_nombre, string guia_apellidom, string guia_apellidop)
        {
            IdGrupo1 = idGrupo;
            this.TipoActividad = tipoActividad;
            this.Colegio = colegio;
            this.Fecha = fecha;
            this.Guia_nombre = guia_nombre;
            this.Guia_apellidom = guia_apellidom;
            this.Guia_apellidop = guia_apellidop;
        }

        public int IdGrupo1 { get => IdGrupo; set => IdGrupo = value; }
        public string TipoActividad { get => tipoActividad; set => tipoActividad = value; }
        public string Colegio { get => colegio; set => colegio = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Guia_nombre { get => guia_nombre; set => guia_nombre = value; }
        public string Guia_apellidom { get => guia_apellidom; set => guia_apellidom = value; }
        public string Guia_apellidop { get => guia_apellidop; set => guia_apellidop = value; }
    }
}

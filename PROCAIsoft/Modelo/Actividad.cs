using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    
    public class Actividad
    {
        private static int i;
        private int IdActividad;
        private TipoActividad tipoActividad;
        private DateTime fechaProgramada;
        private int estadoActividad;
        private int cantEstudiantes;
        private Merchandising materialRepartido;
        private List<GrupoEncuestas> gruposDeEncuestas;

        public Actividad(DateTime fechaProgramada, int estadoActividad, int cantEstudiantes)
        {
            this.estadoActividad= estadoActividad;
            this.fechaProgramada = fechaProgramada;
            this.cantEstudiantes = cantEstudiantes;
            this.gruposDeEncuestas = new List<GrupoEncuestas>();
        }

        public int IdActividad1 { get => IdActividad; set => IdActividad = value; }
        public DateTime FechaProgramada { get => fechaProgramada; set => fechaProgramada = value; }
        public int EstadoActividad { get => estadoActividad; set => estadoActividad = value; }
        public int CantEstudiantes { get => cantEstudiantes; set => cantEstudiantes = value; }
        public List<GrupoEncuestas> GruposDeEncuestas { get => gruposDeEncuestas; set => gruposDeEncuestas = value; }
        public TipoActividad TipoActividad { get => tipoActividad; set => tipoActividad = value; }
        public Merchandising MaterialRepartido { get => materialRepartido; set => materialRepartido = value; }
        public string nombreDeTipoYfecha { get => tipoActividad.Nombre + " - " + fechaProgramada; }
        public void setTipoActividad(TipoActividad tip)
        {
            this.tipoActividad = tip;
            tip.ListaActividades.Add(this);
        }
        public void setMaterialRepartido(Merchandising mer)
        {
            this.materialRepartido = mer;
            mer.Actividades.Add(this);
        }
        public void addGrupoEncuestas(GrupoEncuestas gru)
        {
            this.gruposDeEncuestas.Add(gru);
            gru.Actividad = this;
        }
        public override string ToString()
        {
            return this.TipoActividad.Nombre;
        }
    }
}


using System;
using System.Collections.Generic;

namespace Modelo
{
    public class ProcesoAdmision
    {
        protected static int i = 0;
        private int IdProceso;
        private TipoProcesoAdmision tipoProceso;
        private string nombreProceso;
        private DateTime fechaRealizacion;
        private int cantVacantes;
        private int cantInscritos;
        private List<PostulanteXprocesoAdmision> postulacionesDeProceso;

        public ProcesoAdmision(TipoProcesoAdmision tipoProceso, string nombreProceso, string descripcion, DateTime fechaRealizacion, int cantVacantes,int cantInscritos)
        {
            IdProceso = ++i;
            this.tipoProceso = tipoProceso;
            this.nombreProceso = nombreProceso;
            this.fechaRealizacion = fechaRealizacion;
            this.cantVacantes = cantVacantes;
            this.cantInscritos = cantInscritos;
            this.postulacionesDeProceso = new List<PostulanteXprocesoAdmision>();
        }

        public int IdProceso1 { get => IdProceso; set => IdProceso = value; }
        public string NombreProceso { get => nombreProceso; set => nombreProceso = value; }
        public DateTime FechaRealizacion { get => fechaRealizacion; set => fechaRealizacion = value; }
        public int CantVacantes { get => cantVacantes; set => cantVacantes = value; }
        public List<PostulanteXprocesoAdmision> PostulacionesDeProceso { get => postulacionesDeProceso; set => postulacionesDeProceso = value; }
        public TipoProcesoAdmision TipoProceso { get => tipoProceso; set => tipoProceso = value; }
        public int CantInscritos { get => cantInscritos; set => cantInscritos = value; }

        public void setTipoProceso(TipoProcesoAdmision tip)
        {
            this.tipoProceso = tip;
            tip.ProcesosCreados.Add(this);
        }
        public void addPostulacionDeProceso(PostulanteXprocesoAdmision pxp)
        {
            this.postulacionesDeProceso.Add(pxp);
            pxp.ProcesoDeAdmision = this;
        }
    }
}
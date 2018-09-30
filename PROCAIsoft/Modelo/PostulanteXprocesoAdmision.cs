using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class PostulanteXprocesoAdmision
    {
        protected static int i = 0;
        private int IdPostulanteXprocesoAdmision;
        private int estadoAdmision;
        private string codVaucher;
        private Escolar postulante;
        private Carrera carrera;
        private ProcesoAdmision procesoDeAdmision;

        public PostulanteXprocesoAdmision(int idPostulanteXprocesoAdmision, int estadoAdmision, string codVaucher)
        {
            IdPostulanteXprocesoAdmision = ++i;
            this.estadoAdmision = estadoAdmision;
            this.codVaucher = codVaucher;
        }

        public int IdPostulanteXprocesoAdmision1 { get => IdPostulanteXprocesoAdmision; set => IdPostulanteXprocesoAdmision = value; }
        public int EstadoAdmision { get => estadoAdmision; set => estadoAdmision = value; }
        public string CodVaucher { get => codVaucher; set => codVaucher = value; }
        public Escolar Postulante { get => postulante; set => postulante = value; }
        public Carrera Carrera { get => carrera; set => carrera = value; }
        public ProcesoAdmision ProcesoDeAdmision { get => procesoDeAdmision; set => procesoDeAdmision = value; }
        public void setPostulante(Escolar esc)
        {
            this.postulante = esc;
            esc.PostulacionesRealizadas.Add(this);
        }
        public void setCarrera(Carrera car)
        {
            this.carrera = car;
            car.PostulacionesDeCarrera.Add(this);
        }
        public void setProcesoDeAdmision(ProcesoAdmision pro)
        {
            this.procesoDeAdmision = pro;
            pro.PostulacionesDeProceso.Add(this);
        }
    }
}
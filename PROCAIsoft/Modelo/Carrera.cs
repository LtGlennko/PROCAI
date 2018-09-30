using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Carrera
    {
        protected static int i = 0;
        private int IdCarrera;
        private string nombreCarrera;
        private List<PostulanteXprocesoAdmision> postulacionesDeCarrera;

        public Carrera(string nombreCarrera)
        {
            IdCarrera = ++i;
            this.nombreCarrera = nombreCarrera;
            this.postulacionesDeCarrera = new List<PostulanteXprocesoAdmision>();
        }

        public int IdCarrera1 { get => IdCarrera; set => IdCarrera = value; }
        public string NombreCarrera { get => nombreCarrera; set => nombreCarrera = value; }
        public List<PostulanteXprocesoAdmision> PostulacionesDeCarrera { get => postulacionesDeCarrera; set => postulacionesDeCarrera = value; }

        public void addPostulacionDeCarrera(PostulanteXprocesoAdmision pxp)
        {
            this.postulacionesDeCarrera.Add(pxp);
            pxp.Carrera = this;
        }
    }
}
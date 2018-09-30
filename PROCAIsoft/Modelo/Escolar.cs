using System;
using System.Collections.Generic;
namespace Modelo
{
    public class Escolar : Usuario
    {
        protected static int i = 0;
        private int IdEscolar;
        private TipoGrado grado;
        private int telefonoApoderado;
        private bool esPostulante;
        private Colegio colegio;
        private List<PostulanteXprocesoAdmision> postulacionesRealizadas;

        public Escolar(int dNI, string nombres, string apellidoPaterno, string apellidoMaterno, int celular, TipoSexo sexo, string correoElectronico, TipoGrado grado, int telefonoApoderado, Colegio colegio) : base(dNI, nombres, apellidoPaterno, apellidoMaterno, celular, sexo, correoElectronico)
        {
            IdEscolar = ++i;
            this.grado = grado;
            this.telefonoApoderado = telefonoApoderado;
            this.esPostulante = false;
            this.colegio = colegio;
            this.NivelPermiso = 1;
            postulacionesRealizadas = new List<PostulanteXprocesoAdmision>();
        }

        public int IdEscolar1 { get => IdEscolar; set => IdEscolar = value; }
        public TipoGrado Grado { get => grado; set => grado = value; }
        public int TelefonoApoderado { get => telefonoApoderado; set => telefonoApoderado = value; }
        public bool EsPostulante { get => esPostulante; set => esPostulante = value; }
        public Colegio Colegio { get => colegio; set => colegio = value; }
        public List<PostulanteXprocesoAdmision> PostulacionesRealizadas { get => postulacionesRealizadas; set => postulacionesRealizadas = value; }
        public void setColegio(Colegio col)
        {
            this.colegio = col;
            col.Escolares.Add(this);
        }
        public void addPostulacionRealizada(PostulanteXprocesoAdmision pos)
        {
            postulacionesRealizadas.Add(pos);
            pos.Postulante = this;
        }
    }
}
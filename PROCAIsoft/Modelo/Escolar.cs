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

        public Escolar(string dNI, string nombres, string apellidoPaterno, string apellidoMaterno, int celular, TipoSexo sexo, string correoElectronico, DateTime fechaCreacion, int nivelPermiso, TipoGrado grado, int telefonoApoderado) : base(dNI, nombres, apellidoPaterno, apellidoMaterno, celular, sexo, correoElectronico, fechaCreacion, nivelPermiso)
        {
            IdEscolar = ++i;
            this.grado = grado;
            this.telefonoApoderado = telefonoApoderado;
            this.esPostulante = false;
            this.NivelPermiso = 1;
            postulacionesRealizadas = new List<PostulanteXprocesoAdmision>();
        }
        public string gradoStr(TipoGrado grado)
        {
            if (grado == TipoGrado.Tercero)
                return "3ro";
            if (grado == TipoGrado.Cuarto)
                return "4to";
            return "5to";
        }

        public int gradoInt(TipoGrado grado)
        {
            if (grado == TipoGrado.Tercero)
                return 3;
            if (grado == TipoGrado.Cuarto)
                return 4;
            return 5;
        }

        public int IdEscolar1 { get => IdEscolar; set => IdEscolar = value; }
        public TipoGrado Grado { get => grado; set => grado = value; }
        public int TelefonoApoderado { get => telefonoApoderado; set => telefonoApoderado = value; }
        public bool EsPostulante { get => esPostulante; set => esPostulante = value; }
        public Colegio Colegio { get => colegio; set => colegio = value; }
        public string ColegioStr { get => colegio.Nombre; }
        public List<PostulanteXprocesoAdmision> PostulacionesRealizadas { get => postulacionesRealizadas; set => postulacionesRealizadas = value; }
        public string GradoStr { get => gradoStr(Grado); }
        public int GradoInt { get => gradoInt(Grado); }
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
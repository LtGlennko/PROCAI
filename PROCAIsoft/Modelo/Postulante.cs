using System;
using System.Collections.Generic;
namespace Modelo
{
    public class Postulante : Escolar
    {
        private int IdPostulante;
        private List<PostulanteXprocesoAdmision> postulanteXproceso;

        //Constructadores
        public Postulante(DateTime fechaCreacion, int nivelPermiso,
                          int idEscolar, List<Colegio> colegio, string grado, int telefonoApoderado,
                          int IdPostulante, List<PostulanteXprocesoAdmision> postulanteXproceso)
                         : base(fechaCreacion, nivelPermiso,//usuario logueable
                        idEscolar, colegio, grado, telefonoApoderado)
        {
            this.IdPostulante = IdPostulante;
            this.postulanteXproceso = postulanteXproceso;
        }

        public List<PostulanteXprocesoAdmision> PostulanteXproceso { get => postulanteXproceso; set => postulanteXproceso = value; }
        public int IdPostulante1 { get => IdPostulante; set => IdPostulante = value; }
    }
}
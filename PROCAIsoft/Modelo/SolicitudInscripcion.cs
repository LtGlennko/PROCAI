using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    class SolicitudInscripcion
    {
        private int IdSolicitudInscripcion;
        private int cantAlumnos;
        private int grado;
        private DateTime fecha;
        private Orientador solicitante;
        private Colegio colegioAsistente;
        private Actividad actividad;

        public SolicitudInscripcion(int idSolicitudInscripcion, int cantAlumnos, int grado, DateTime fecha)
        {
            IdSolicitudInscripcion = idSolicitudInscripcion;
            this.cantAlumnos = cantAlumnos;
            this.grado = grado;
            this.fecha = fecha;
        }

        public int IdSolicitudInscripcion1 { get => IdSolicitudInscripcion; set => IdSolicitudInscripcion = value; }
        public int CantAlumnos { get => cantAlumnos; set => cantAlumnos = value; }
        public int Grado { get => grado; set => grado = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public Orientador Solicitante { get => solicitante; set => solicitante = value; }
        public Colegio ColegioAsistente { get => colegioAsistente; set => colegioAsistente = value; }
        public Actividad Actividad { get => actividad; set => actividad = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Modelo;
using System.ComponentModel;

namespace LogicaNegocio
{
    public class EncuestaBL
    {
        private EncuestaDA encuestaDA;
        private CalificacionPXEDA calificacionPXEDA;
        public EncuestaBL()
        {
            encuestaDA = new EncuestaDA();
            calificacionPXEDA = new CalificacionPXEDA();
        }

        public BindingList<Encuesta> listarEncuestas(GrupoEncuestas G)
        {
            return encuestaDA.listarEncuestas(G.IdGrupoEncuestas1);
        }

        public int registrarEncuesta (Encuesta E, int idUsu)
        {
            int idEncuesta = encuestaDA.registrarEncuesta(E, idUsu);
            //Si devuelve 0 es porque no pudo registrar bien
            if (idEncuesta == 0) return 0;
            foreach(CalificacionPXE c in E.CalificacionesPorEncuesta)
            {
                if(!calificacionPXEDA.registrarCalificacionPXE(c, idEncuesta)) return 0;
            }
            return idEncuesta;
        }

        //public bool modificarEncuesta(Encuesta E, int idUsu)
        //{
        //    return encuestaDA.modificarEncuesta(E, idUsu);
        //}
    }
}

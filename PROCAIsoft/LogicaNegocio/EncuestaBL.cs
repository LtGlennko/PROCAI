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

        public BindingList<Encuesta> listarEncuestas()
        {
            return encuestaDA.listarEncuestas();
        }

        public bool registrarEncuesta (Encuesta E, int idUsu)
        {
            int idEncuesta = encuestaDA.registrarEncuesta(E, idUsu);
            if (idEncuesta == 0) return false;
            foreach(CalificacionPXE c in E.CalificacionesPorEncuesta)
            {
                if(!calificacionPXEDA.registrarCalificacionPXE(c, idEncuesta)) return false;
            }
            return true;
        }

        public bool modificarEncuesta(Encuesta E, int idUsu)
        {
            return encuestaDA.modificarEncuesta(E, idUsu);
        }
    }
}

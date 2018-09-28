using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class PostulanteXprocesoAdmision
    {
        private int IdPostulanteXprocesoAdmision;
        private DateTime date;
        private int estadoAdmision;

        public PostulanteXprocesoAdmision(int id, int yy, int mm, int dd, int estado)
        {
            IdPostulanteXprocesoAdmision = id;
            date = new DateTime(yy, mm, dd);
            estadoAdmision = estado;
        }

        public int Idpostulante
        {
            set
            {
                IdPostulanteXprocesoAdmision = value;
            }
            get
            {
                return IdPostulanteXprocesoAdmision;
            }
        }

        public int estadoadmision
        {
            set
            {
                estadoAdmision = value;
            }
            get
            {
                return estadoAdmision;
            }
        }

    }
}
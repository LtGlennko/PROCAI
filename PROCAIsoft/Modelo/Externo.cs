using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Externo /*: Persona*/
    {
        private int IdApoderado;
        private string profesion;
        private bool esEgresadoPUCP;

        public Externo()
        {
        }

        public Externo(int IDp, int DNI, string nombre, string ap, string am, string correo, int telefono, char sexo,
                        int IdApoderado, string profesion, bool esEgresadoPUCP)
        /*:base(IDp, DNI, nombre, ap, am, correo, telefono, sexo)*/
        {
            this.IdApoderado = IdApoderado;
            this.profesion = profesion;
            this.esEgresadoPUCP = esEgresadoPUCP;
        }
        /**
         * @return the IdApoderado
         */
        public int getIdApoderado()
        {
            return IdApoderado;
        }

        /**
         * @param IdApoderado the IdApoderado to set
         */
        public void setIdApoderado(int IdApoderado)
        {
            this.IdApoderado = IdApoderado;
        }

        /**
         * @return the profesion
         */
        public string getProfesion()
        {
            return profesion;
        }

        /**
         * @param profesion the profesion to set
         */
        public void setProfesion(string profesion)
        {
            this.profesion = profesion;
        }

        /**
         * @return the esEgresadoPUCP
         */
        public bool isEsEgresadoPUCP()
        {
            return esEgresadoPUCP;
        }

        /**
         * @param esEgresadoPUCP the esEgresadoPUCP to set
         */
        public void setEsEgresadoPUCP(bool esEgresadoPUCP)
        {
            this.esEgresadoPUCP = esEgresadoPUCP;
        }

        ~Externo()
        {
            System.Console.WriteLine("destructor");
        }
    }
}
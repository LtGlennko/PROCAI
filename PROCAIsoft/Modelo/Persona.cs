using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Persona
    {
        private int IdPersona;
        private int DNI;
        private string nombres;
        private string apellidoPaterno;
        private string apellidoMaterno;
        private string correoElectronico;
        private int celular;
        private char sexo;

        //Contructadores
        public Persona()
        {
        }

        public Persona(int idPersona, int dNI, string nombres, string apellidoPaterno, string apellidoMaterno, string correoElectronico, int celular, char sexo)
        {
            IdPersona = idPersona;
            DNI = dNI;
            this.nombres = nombres;
            this.apellidoPaterno = apellidoPaterno;
            this.apellidoMaterno = apellidoMaterno;
            this.correoElectronico = correoElectronico;
            this.celular = celular;
            this.sexo = sexo;
        }

        public void setNombres(string nombres)
        {
            this.nombres = nombres;
        }
        public string getNombres()
        {
            return this.nombres;
        }
        public void setApellidoPaterno(string apellidoPaterno)
        {
            this.apellidoPaterno = apellidoPaterno;
        }
        public string getApellidoPaterno()
        {
            return this.apellidoPaterno;
        }

        public void setApellidoMaterno(string apellidoMaterno)
        {
            this.apellidoMaterno = apellidoMaterno;
        }
        public string getApellidoMaterno()
        {
            return this.apellidoMaterno;
        }

        public void setDNI(int DNI)
        {
            this.DNI = DNI;
        }
        public int getDNI()
        {
            return this.DNI;
        }

        public void setIdPersona(int IdPersona)
        {
            this.IdPersona = IdPersona;
        }
        public int getIdPersona()
        {
            return this.IdPersona;
        }

        public void setCelular(int celular)
        {
            this.celular = celular;
        }
        public int getCelular()
        {
            return this.celular;
        }


        public void setCorreoElectronico(string correoElectronico)
        {
            this.correoElectronico = correoElectronico;
        }
        public string getCorreoElectronico()
        {
            return this.correoElectronico;
        }

        public void setSexo(char sexo)
        {
            this.sexo = sexo;
        }
        public char getSexo()
        {
            return this.sexo;
        }
    }
}

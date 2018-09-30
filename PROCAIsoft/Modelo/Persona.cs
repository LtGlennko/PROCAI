using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Persona
    {
        protected static int i = 0;
        private int IdPersona;
        private int DNI;
        private string nombres;
        private string apellidoPaterno;
        private string apellidoMaterno;        
        private int celular;
        private TipoSexo sexo;
        private string correoElectronico;

        public Persona(int dNI, string nombres, string apellidoPaterno, string apellidoMaterno, int celular, TipoSexo sexo, string correoElectronico)
        {
            IdPersona = ++i;
            DNI = dNI;
            this.nombres = nombres;
            this.apellidoPaterno = apellidoPaterno;
            this.apellidoMaterno = apellidoMaterno;
            this.celular = celular;
            this.sexo = sexo;
            this.correoElectronico = correoElectronico;
        }

        public int IdPersona1 { get => IdPersona; set => IdPersona = value; }
        public int DNI1 { get => DNI; set => DNI = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string ApellidoPaterno { get => apellidoPaterno; set => apellidoPaterno = value; }
        public string ApellidoMaterno { get => apellidoMaterno; set => apellidoMaterno = value; }
        public int Celular { get => celular; set => celular = value; }
        public TipoSexo Sexo { get => sexo; set => sexo = value; }
        public string CorreoElectronico { get => correoElectronico; set => correoElectronico = value; }
    }
}

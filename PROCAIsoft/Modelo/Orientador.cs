using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Orientador : Usuario
    {
        protected static int i = 0;
        private int IdOrientador;
        private Colegio colegio;

        public Orientador(string dNI, string nombres, string apellidoPaterno, string apellidoMaterno, int celular, TipoSexo sexo, string correoElectronico, DateTime fechaCreacion, int nivelPermiso) : base(dNI, nombres, apellidoPaterno, apellidoMaterno, celular, sexo, correoElectronico, fechaCreacion, nivelPermiso)
        {
            IdOrientador = ++i;

        }

        public int IdOrientador1 { get => IdOrientador; set => IdOrientador = value; }
        public Colegio Colegio { get => colegio; set => colegio = value; }
        public void setColegio(Colegio cole)
        {
            this.colegio = cole;
            cole.Orientadores.Add(this);
        }
    }
}
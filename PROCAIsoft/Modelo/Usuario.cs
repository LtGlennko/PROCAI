using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Usuario : Persona
    {
        protected static int i=0;
        private int IdUsuario;
        private DateTime fechaCreacion;
        private int nivelPermiso;
        private Cuenta cuentaUsuario;


        public Usuario(string dNI, string nombres, string apellidoPaterno, string apellidoMaterno, int celular, TipoSexo sexo, string correoElectronico, DateTime fechaCreacion, int nivelPermiso) : base(dNI, nombres, apellidoPaterno, apellidoMaterno, celular, sexo, correoElectronico)
        {
            IdUsuario = ++i;
            this.fechaCreacion = fechaCreacion;
            this.nivelPermiso = nivelPermiso;
        }

        public int IdUsuario1 { get => IdUsuario; set => IdUsuario = value; }
        public DateTime FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }
        public int NivelPermiso { get => nivelPermiso; set => nivelPermiso = value; }
        public Cuenta CuentaUsuario { get => cuentaUsuario; set => cuentaUsuario = value; }
        public string NombreCuenta { get => cuentaUsuario.NombreDeUsuario; }
        public void setCuenta(Cuenta cue)
        {
            this.cuentaUsuario = cue;
            cue.Usuario = this;
        }
    }
}

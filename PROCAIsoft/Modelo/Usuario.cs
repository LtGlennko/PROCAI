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

        public Usuario(int dNI, string nombres, string apellidoPaterno, string apellidoMaterno, int celular, TipoSexo sexo, string correoElectronico) : base(dNI, nombres, apellidoPaterno, apellidoMaterno, celular, sexo, correoElectronico)
        {
            IdUsuario = ++i;
            this.fechaCreacion = DateTime.Today;
            this.nivelPermiso = 1;
        }

        public int IdUsuario1 { get => IdUsuario; set => IdUsuario = value; }
        public DateTime FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }
        public int NivelPermiso { get => nivelPermiso; set => nivelPermiso = value; }
        public Cuenta CuentaUsuario { get => cuentaUsuario; set => cuentaUsuario = value; }
        public void setCuenta(Cuenta cuen)
        {
            this.cuentaUsuario = cuen;
            cuen.Usuario = this;
        }
    }
}

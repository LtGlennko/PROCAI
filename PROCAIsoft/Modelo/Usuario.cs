using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Usuario
    {
        private static int i=0;
        private int IdUsuario;
        private DateTime fechaCreacion;
        private int nivelPermiso;
        private CuentaUsuario cuentaUsuario;

        public Usuario(DateTime fechaCreacion, int nivelPermiso)
        {
            IdUsuario = ++i;
            this.fechaCreacion = fechaCreacion;
            this.nivelPermiso = nivelPermiso;
        }

        protected static int I { get => i; set => i = value; }
        public int IdUsuario1 { get => IdUsuario; set => IdUsuario = value; }
        public DateTime FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }
        public int NivelPermiso { get => nivelPermiso; set => nivelPermiso = value; }
        public string NombreUsuario { get => CuentaUsuario.NombreDeUsuario; }
        public CuentaUsuario CuentaUsuario { get => cuentaUsuario; set => cuentaUsuario = value; }
    }
}

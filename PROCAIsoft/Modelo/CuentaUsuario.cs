using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class CuentaUsuario
    {
        protected static int i = 0;
        private int IdCuenta;
        private DateTime ultimaConexion;
        private string nombreDeUsuario;
        private string contrasena;
        private Usuario usuario;

        public CuentaUsuario(DateTime ultimaConexion, string nombreDeUsuario, string contrasena, Usuario usuario)
        {
            IdCuenta = ++i;
            this.ultimaConexion = ultimaConexion;
            this.nombreDeUsuario = nombreDeUsuario;
            this.contrasena = contrasena;
            this.usuario = usuario;
            usuario.CuentaUsuario = this;
        }

        public int IdCuenta1 { get => IdCuenta; set => IdCuenta = value; }
        public DateTime UltimaConexion { get => ultimaConexion; set => ultimaConexion = value; }
        public string NombreDeUsuario { get => nombreDeUsuario; set => nombreDeUsuario = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        public Usuario Usuario { get => usuario; set => usuario = value; }
    }
}

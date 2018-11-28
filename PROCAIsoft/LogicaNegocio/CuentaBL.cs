using AccesoDatos;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class CuentaBL
    {
        private CuentaDA cuentaDA;
        public CuentaBL()
        {
            cuentaDA = new CuentaDA();
        }
        public bool existeNombreUsuario(Cuenta C)
        {
            int existe = cuentaDA.existeNombreUsuario(C.NombreDeUsuario);
            if (existe == 1)
                return true;
            return false;
        }

        public bool registrarCuenta(int idUsuario, Cuenta C)
        {
            return cuentaDA.registrarCuenta(idUsuario, C);
        }
    }
}

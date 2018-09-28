using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Administrativo : TrabajadorOCAI
    {
        protected static int i = 0;
        private int idAdministrativo;
        private int telefonoOfi;
        private int celularOfi;
        private string correoOfi;
        public Administrativo(DateTime fechaCreacion, int nivelPermiso, DateTime fechaIngreso, int estadoTrabajador, int telefonoOfi, int celularOfi, string correoOfi) : base(fechaCreacion, nivelPermiso, fechaIngreso, estadoTrabajador)
        {
            this.idAdministrativo = ++i;
            this.telefonoOfi = telefonoOfi;
            this.celularOfi = celularOfi;
            this.correoOfi = correoOfi;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class TrabajadorOCAI : Usuario
    {
        protected static int i = 0;
        private int IdTrabajadorOCAI;
        private Cargo cargo;
        private DateTime fechaIngreso;
        private int telefonoOfi;
        private int celularOfi;
        private string correOfi;
        public TrabajadorOCAI(Usuario usu, DateTime fechaIngreso, int telefonoOfi, int celularOfi, string correOfi) : base(usu.DNI1, usu.Nombres, usu.ApellidoPaterno, usu.ApellidoMaterno, usu.Celular, usu.Sexo, usu.CorreoElectronico, usu.FechaCreacion, usu.NivelPermiso)
        {
            IdTrabajadorOCAI = ++i;
            this.fechaIngreso = fechaIngreso;
            this.telefonoOfi = telefonoOfi;
            this.celularOfi = celularOfi;
            this.correOfi = correOfi;
            this.setCuenta(usu.CuentaUsuario);
        }

        public TrabajadorOCAI(string dNI, string nombres, string apellidoPaterno, string apellidoMaterno, int celular, TipoSexo sexo, string correoElectronico, DateTime fechaCreacion, int nivelPermiso, DateTime fechaIngreso, int telefonoOfi, int celularOfi, string correOfi) : base(dNI, nombres, apellidoPaterno, apellidoMaterno, celular, sexo, correoElectronico, fechaCreacion, nivelPermiso)
        {
            IdTrabajadorOCAI = ++i;
            this.fechaIngreso = fechaIngreso;
            this.telefonoOfi = telefonoOfi;
            this.celularOfi = celularOfi;
            this.correOfi = correOfi;
        }

        public int IdTrabajadorOCAI1 { get => IdTrabajadorOCAI; set => IdTrabajadorOCAI = value; }
        public Cargo Cargo { get => cargo; set => cargo = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public int TelefonoOfi { get => telefonoOfi; set => telefonoOfi = value; }
        public int CelularOfi { get => celularOfi; set => celularOfi = value; }
        public string CorreOfi { get => correOfi; set => correOfi = value; }
        public void setCargo(Cargo car)
        {
            this.cargo = car;
            car.ListaTrabajadores.Add(this);
        }
    }
}

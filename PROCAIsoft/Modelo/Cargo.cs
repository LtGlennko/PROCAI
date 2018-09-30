using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Cargo
    {
        protected static int i = 0;
        private int IdCargo;
        private string nombreCargo;
        private List<TrabajadorOCAI> listaTrabajadores;

        public Cargo(string nombreCargo)
        {
            IdCargo = ++i;
            this.nombreCargo = nombreCargo;
        }

        public int IdCargo1 { get => IdCargo; set => IdCargo = value; }
        public string NombreCargo { get => nombreCargo; set => nombreCargo = value; }
        public List<TrabajadorOCAI> ListaTrabajadores { get => listaTrabajadores; set => listaTrabajadores = value; }
        public void addTrabajador(TrabajadorOCAI tra)
        {
            this.listaTrabajadores.Add(tra);
            tra.Cargo = this;
        }
    }
}
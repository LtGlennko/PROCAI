using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Cargo
    {
        private int IdCargo;
        private string nombreCargo;
        private List<TrabajadorOCAI> Trabajadores;

        public Cargo()
        {
            this.Trabajadores = new List<TrabajadorOCAI>();
        }

        public Cargo(int IdCargo, string nombreCargo)
        {
            this.IdCargo = IdCargo;
            this.nombreCargo = nombreCargo;
            this.Trabajadores = new List<TrabajadorOCAI>();
        }

        public int getIdCargo() { return this.IdCargo; }
        public string getNombreCargo() { return this.nombreCargo; }

        public void setIdCargo(int IdCargo)
        {
            this.IdCargo = IdCargo;
        }

        public void setNombreCargo(string nombreCargo)
        {
            this.nombreCargo = nombreCargo;
        }

        public void addTrabajadorOCAI(TrabajadorOCAI Trab)
        {
            this.Trabajadores.Add(Trab);
        }
    }
}
using AccesoDatos;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class CargoBL
    {
        CargoDA cargoDA;
        public CargoBL()
        {
            cargoDA = new CargoDA();
        }
        public BindingList<Cargo> listarCargos()
        {
            return cargoDA.listaCargos();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using AccesoDatos;
using System.ComponentModel;

namespace LogicaNegocio
{
    public class RegionBL
    {
        private RegionDA regda;
        public RegionBL()
        {
            regda = new RegionDA();
        }

        public BindingList<Region> listarRegion()
        {
            return regda.listarRegion();
        }
    }
}

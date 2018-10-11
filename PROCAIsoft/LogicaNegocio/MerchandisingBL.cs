using Modelo;
using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;


namespace LogicaNegocio
{
    public class MerchandisingBL
    {
        private MerchandisingDA merchandisingDA;
        public MerchandisingBL()
        {
           merchandisingDA  = new MerchandisingDA();
        }

        public BindingList<Merchandising> listarMerchandising()
        {
            return merchandisingDA.listarMerchandising();
        }

        public bool registarMerchandising(Merchandising m)
        {
            return merchandisingDA.registrarMerchandising(m);
        }
        public void actualizarMerchandising(Merchandising m)
        {
            merchandisingDA.actualizarMerchandising(m);
        }
    }
}

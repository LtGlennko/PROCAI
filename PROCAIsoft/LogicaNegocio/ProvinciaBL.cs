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
    public class ProvinciaBL
    {
        private ProvinciaDA provda;
        
        public ProvinciaBL()
        {
            provda = new ProvinciaDA();
        }

        public BindingList<Provincia> listarPronvincia(string id)
        {
            return provda.listarProvincia(id);
        }
    }
}

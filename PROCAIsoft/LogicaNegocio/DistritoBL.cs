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
    public class DistritoBL
    {
        private DistritoDA distda;

        public DistritoBL()
        {
            distda = new DistritoDA();
        }

        public BindingList<Distrito> listarDistrito(string idp)
        {
            return distda.listarDistrito(idp);
        }
    }
}

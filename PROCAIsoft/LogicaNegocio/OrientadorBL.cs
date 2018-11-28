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
    public class OrientadorBL
    {
        private OrientadorDA orientadorDA;
        public OrientadorBL()
        {
            orientadorDA = new OrientadorDA();
        }
        //public int registrarEscolar(Orientador O)
        //{
        //    return orientadorDA.registrarEscolar(E);
        //}

        public BindingList<Orientador> listarOrientadores()
        {
            return orientadorDA.listarOrientadores();
        }
    }
}

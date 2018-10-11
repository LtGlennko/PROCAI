using AccesoDatos;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace LogicaNegocio
{
    public class ColegioBL
    {
        private ColegioDA colegioDA;
        public ColegioBL()
        {
            colegioDA = new ColegioDA();
        }

        public bool registrarColegio(Colegio colegio)
        {
            return colegioDA.registrarColegio(colegio);
        }

        public BindingList<Colegio> listarColegios()
        {
            return colegioDA.listarColegio();
        }
    }
     
}

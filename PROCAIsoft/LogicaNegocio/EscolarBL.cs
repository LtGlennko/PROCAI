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
    public class EscolarBL
    {
        private EscolarDA escolarDA;
        public EscolarBL()
        {
            escolarDA = new EscolarDA();
        }
        public int registrarEscolar(Escolar E)
        {
            return escolarDA.registrarEscolar(E);
        }

        public BindingList<Escolar> listarEscolares()
        {
            return escolarDA.listarEscolares();
        }
    }
}

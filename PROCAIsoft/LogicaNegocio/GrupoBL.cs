using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Modelo;
using System.ComponentModel;
namespace LogicaNegocio
{
    public class GrupoBL
    {
        private GrupoDA grupoDA;

        public GrupoBL()
        {
            grupoDA = new GrupoDA();

        }

        public BindingList<GrupoEncuestas> listarGrupos()
        {
            return grupoDA.listarGrupos();
        }

    }
}

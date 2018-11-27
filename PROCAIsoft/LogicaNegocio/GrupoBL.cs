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
        private EncuestaBL encuestaBL;

        public GrupoBL()
        {
            grupoDA = new GrupoDA();
            encuestaBL = new EncuestaBL();
        }
        public BindingList<GrupoEncuestas> listarGrupos()
        {
            //Se listan los grupos sin los detalles de sus encuestas
            return grupoDA.listarGrupos();
        }

        public int registrarGrupo(GrupoEncuestas G)
        {
            return grupoDA.registrarGrupo(G);
        }
    }
}

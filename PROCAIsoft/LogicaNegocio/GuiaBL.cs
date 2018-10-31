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
    public class GuiaBL
    {
        private GuiaDA guiaDA;
        public GuiaBL()
        {
            guiaDA = new GuiaDA();
        }

        public Guia crearGuia(Usuario u)
        {
            return guiaDA.crearGuia(u);
        }

        public BindingList<Guia> listarGuias()
        {
            return guiaDA.listarGuias();
        }
    }
}

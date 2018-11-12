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
        private UsuarioDA usuarioDA;
        public GuiaBL()
        {
            guiaDA = new GuiaDA();
            usuarioDA = new UsuarioDA();
        }

        public Guia crearGuia(Usuario u)
        {
            return guiaDA.crearGuia(u);
        }

        public BindingList<Guia> listarGuias()
        {
            //En vez de listarGuias Guias de guiaDA usaré metodos ya usadoa antes
            BindingList<Usuario> usuarios = usuarioDA.listarUsuarios();
            BindingList<Guia> guias = new BindingList<Guia>();
            foreach(Usuario u in usuarios)
            {
                Guia g = guiaDA.crearGuia(u);
                //Inserta si el usuario es un guia
                if(g != null)
                {
                    guias.Add(g);
                }
            }
            return guias;
        }
    }
}

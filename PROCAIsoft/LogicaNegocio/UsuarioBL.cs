﻿using AccesoDatos;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class UsuarioBL
    {
        private UsuarioDA usuarioDA;
        public UsuarioBL()
        {
            usuarioDA = new UsuarioDA();
        }

        public BindingList<Usuario> listarUsuarios()
        {
            return usuarioDA.listarUsuarios();
        }

        public BindingList<Usuario> listarUsuariosSinGestionador(int idJefe)
        {
            return usuarioDA.listarUsuariosSinGestionador(idJefe);
        }

        public Usuario buscarUsuario(string username, string password)
        {            
            return usuarioDA.buscarUsuario(username, password);
        }
    }
}

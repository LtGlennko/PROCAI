﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Modelo;

namespace LogicaNegocio
{    
    public class UsuarioBL
    {
        private UsuarioDA usuarioDA;
        public UsuarioBL()
        {
            UsuarioDA usuarioDA = new UsuarioDA();
        }

        public BindingList<Usuario> listarUsuarios()
        {
            return usuarioDA.listarUsuarios();
        }
    }
}

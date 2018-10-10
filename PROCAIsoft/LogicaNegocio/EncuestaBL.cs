﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Modelo;
using System.ComponentModel;

namespace LogicaNegocio
{
    public class EncuestaBL
    {
        private EncuestaDA encuestaDA;

        public EncuestaBL()
        {
            encuestaDA = new EncuestaDA();
        }

        public BindingList<Encuesta> listarEncuestas()
        {
            return encuestaDA.listarEncuestas();
        }
        public bool registrarEncuesta (Encuesta E)
        {
             return encuestaDA.registrarEncuesta(E);
        }
    }
}

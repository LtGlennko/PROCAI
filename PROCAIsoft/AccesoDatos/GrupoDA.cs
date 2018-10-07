using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

//PARA LA VENTANA BUSCAR GROUPO, DE VISUALIZAR ENCUESTA

namespace AccesoDatos
{
    public class GrupoDA
    {
        public BindingList<GrupoEncuestas> listarGrupo(){
            BindingList<GrupoEncuestas> grupos = new BindingList<GrupoEncuestas>();
            //tiene que dar idGrupo, tipo de actividad (dentro de la actividad)
            //colegio, guia, fecha (dentro de la actividad -> tipo de actividad)
            return grupos;
        }
    }
}

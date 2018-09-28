using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Orientador /*: UsuarioLogueable*/
    {
        private int IdOrientador;

        public Orientador()
        {

        }
        public Orientador(int IDp, int DNI, string nombre, string ap, string am, string correo, int telefono, char sexo, //de persona
                                int IdUsusario, string fechaCreacion/*,CuentaUsuario cuenta*/,// de ususario logueable
                                int IdOrientador)//orientador
                                                 /*:base(IDp, DNI, nombre, ap, am, correo, 
                                                 telefono, sexo, IdUsusario, fechaCreacion, cuenta)*/
        {
            this.IdOrientador = IdOrientador;
        }

        /**
         * @return the IdOrientador
         */
        public int getIdOrientador()
        {
            return IdOrientador;
        }

        /**
         * @param IdOrientador the IdOrientador to set
         */
        public void setIdOrientador(int IdOrientador)
        {
            this.IdOrientador = IdOrientador;
        }
        ~Orientador()
        {
            System.Console.WriteLine("destructor");
        }
    }
}
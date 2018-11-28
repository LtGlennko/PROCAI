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
    public class PersonaBL
    {
        PersonaDA personaDA;
        public PersonaBL()
        {
            personaDA = new PersonaDA();
        }
        public BindingList<Persona> listarPersonas()
        {
            return personaDA.listarPersonas();
        }

        public BindingList<Persona> listarPersonasSinUsuario()
        {
            return personaDA.listarPersonasSinUsuario();
        }
    }
}

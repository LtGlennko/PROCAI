using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class PersonaDA
    {
        private MySqlConnection con;
        MySqlCommand comando;
        String sql;

        //SOLO FUNCIONA CON LOS QUE TIENEN CUENTA
        public BindingList<Persona> listarPersonas()
        {
            BindingList<Persona> personas = new BindingList<Persona>();
            con = new MySqlConnection(DBManager.cadena);
            con.Open();
            comando = new MySqlCommand();
            //Este query devuelve las personas que no tienen cuenta
            sql = "SELECT P.* FROM Persona P LEFT JOIN Usuario U ON P.IdPersona = U.IdUsuario WHERE U.IdUsuario IS NULL;";
            comando.CommandText = sql;
            comando.Connection = con;
            MySqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                //Lectura de datos de la persona
                int idPersona = lector.GetInt32("IdPersona");
                string dni = lector.GetString("DNI");
                string nombres = lector.GetString("nombres");
                string apellPat = lector.GetString("apellidoPaterno");
                string apellMat = lector.GetString("apellidoMaterno");
                int celular = lector.GetInt32("celular");
                char sexoC = lector.GetChar("sexo");
                TipoSexo sexo;
                if (sexoC == 'M') sexo = TipoSexo.Hombre;
                else if (sexoC == 'F') sexo = TipoSexo.Mujer;
                else sexo = TipoSexo.Personalizado;
                string correo = lector.GetString("correoElectronico");
                //Creacion de la persona
                Persona p = new Persona(dni, nombres, apellPat, apellMat, celular, sexo, correo);
                p.IdPersona1 = idPersona;
                personas.Add(p);
            }
            con.Close();
            return personas;
        }
    }
}

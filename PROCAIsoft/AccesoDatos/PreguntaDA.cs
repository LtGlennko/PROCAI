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
    public class PreguntaDA
    {
        private MySqlConnection con;
        MySqlCommand comando;
        String sql;
        public BindingList<Pregunta> listaPreguntasSegunActividad(int idTipoActividad)
        {
            BindingList<Pregunta> preguntas = new BindingList<Pregunta>();
            con = new MySqlConnection(DBManager.cadena);
            con.Open();
            comando = new MySqlCommand();
            sql = "SELECT * FROM Pregunta WHERE IdTipoActividad = " + idTipoActividad + ";";
            comando.CommandText = sql;
            comando.Connection = con;
            MySqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                //Lectura de datos de la pregunta
                int idPregunta = lector.GetInt32("IdPregunta");
                string enunciado = lector.GetString("Enunciado");
                int idTipAct = lector.GetInt32("IdTipoActividad");
                Pregunta preg = new Pregunta(enunciado);
                preg.IdPregunta1 = idPregunta;
                //Agregamos la pregunta a la lista
                preguntas.Add(preg);
            }
            con.Close();
            return preguntas;
        }
    }
}

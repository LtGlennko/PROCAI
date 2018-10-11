using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using MySql.Data.MySqlClient;
using System.ComponentModel;

namespace AccesoDatos
{
    public class EncuestaDA
    {
        private MySqlConnection con;
        private MySqlCommand comando;
        private String sql;

        public BindingList<Encuesta> listarEncuestas()
        {
            BindingList<Encuesta> encuestas = new BindingList<Encuesta>();
            con = new MySqlConnection(DBManager.cadena);
            con.Open();
            comando = new MySqlCommand();
            sql = "SELECT IdEncuesta,Digitador,Calificaciones,GrupoPertenciente FROM Encuesta";
            comando.CommandText = sql;
            comando.Connection = con;
            MySqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                int idEncuesta = lector.GetInt32("IdEncuesta");
                //tipos especificos para los otros
                Encuesta e = new Encuesta(/* */);
                e.IdEncuesta1 = idEncuesta;
                encuestas.Add(e);
            }
            con.Close();
            return encuestas;
        }
        public bool registrarEncuesta (Encuesta E, int idGuia)
        {
            try
            {
                int id_grupoEncuesta = E.GrupoPerteneciente.IdGrupoEncuestas1;
                con = new MySqlConnection(DBManager.cadena);

                con.Open();
                comando = new MySqlCommand();
                string sql = "INSERT INTO `Encuesta`(`IdGrupoEncuesta`,`IdGuia`) " +
                             "VALUES("  + id_grupoEncuesta + ", "+ idGuia + ")";
                comando.CommandText = sql;
                comando.Connection = con;
                comando.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

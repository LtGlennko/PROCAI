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
        public int registrarEncuesta(Encuesta E, int idGuia)
        {
            con = new MySqlConnection(DBManager.cadena);
            con.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = con;
            try
            {
                comando.CommandText = "REGISTRAR_ENCUESTA";
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("_IdEncuesta", MySqlDbType.Int32).Direction = System.Data.ParameterDirection.Output;
                comando.Parameters.Add("_IdGrupoEncuesta", MySqlDbType.Int32).Value = E.IdGrupoPerteneciente;
                comando.Parameters.Add("_IdGuia", MySqlDbType.Int32).Value = idGuia;
                comando.ExecuteNonQuery();
                int idGenerado = Int32.Parse(comando.Parameters["_IdEncuesta"].Value.ToString());
                con.Close();
                return idGenerado;
            }
            catch (Exception)
            {
                con.Close();
                return 0;
            }
        }

            public bool modificarEncuesta(Encuesta E, int idGuia)
            {
                try
                {
                    int id_grupoEncuesta = E.GrupoPerteneciente.IdGrupoEncuestas1;
                    con = new MySqlConnection(DBManager.cadena);

                    con.Open();
                    comando = new MySqlCommand();
                    // string sql = "UPDATE `Encuesta`(calificaciones) " +"VALUES(" +cal1 + ", " + cal2 + etc ")"; 
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





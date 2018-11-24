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

        public BindingList<Encuesta> listarEncuestas(int idGrupo)
        {
            BindingList<Encuesta> encuestas = new BindingList<Encuesta>();
            con = new MySqlConnection(DBManager.cadena);
            con.Open();
            comando = new MySqlCommand();
            //Este procedure devuelve la lista de los Id delas encuestas de ese grupo y la cantidad de calificaciones encontradas
            //(Este último debería ser 4, sino es un problema de los registrso de base de datos)
            sql = "SELECT E.IdEncuesta, COUNT(*) AS nCalif FROM Encuesta E, CalificacionPxE C WHERE E.estado = 1 AND E.IdEncuesta = C.IdEncuesta AND IdGrupoEncuesta = 2 GROUP BY E.IdEncuesta";
            //SELECT E.*, P.IdPregunta, C.calificacion FROM GrupoEncuesta G, Pregunta P, Encuesta E, CalificacionPxE C WHERE E.estado = 1 AND E.IdEncuesta = C.IdEncuesta AND E.IdGrupoEncuesta = G.IdGrupoEncuesta AND P.IdPregunta = C.IdPregunta AND G.IdGrupoEncuesta = 16 ORDER BY 5
            comando.CommandText = sql;
            comando.Connection = con;
            MySqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                int idEncuesta = lector.GetInt32("IdEncuesta");
                //Creamos la encuesta
                Encuesta e = new Encuesta();
                e.IdEncuesta1 = idEncuesta;
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
                comando.Parameters.Add("_IdEncuestaIn", MySqlDbType.Int32).Value = E.IdEncuesta1;
                comando.Parameters.Add("_IdEncuestaOut", MySqlDbType.Int32).Direction = System.Data.ParameterDirection.Output;
                comando.Parameters.Add("_IdGrupoEncuesta", MySqlDbType.Int32).Value = E.IdGrupoPerteneciente;
                comando.Parameters.Add("_IdGuia", MySqlDbType.Int32).Value = idGuia;
                comando.ExecuteNonQuery();
                int idGenerado = Int32.Parse(comando.Parameters["_IdEncuestaOut"].Value.ToString());
                con.Close();
                return idGenerado;
            }
            catch (Exception)
            {
                con.Close();
                return 0;
            }
        }


        //NO NECESIDAD DE ESTE
            //public bool modificarEncuesta(Encuesta E, int idGuia)
            //{
            //    try
            //    {
            //        int id_grupoEncuesta = E.GrupoPerteneciente.IdGrupoEncuestas1;
            //        con = new MySqlConnection(DBManager.cadena);

            //        con.Open();
            //        comando = new MySqlCommand();
            //        // string sql = "UPDATE `Encuesta`(calificaciones) " +"VALUES(" +cal1 + ", " + cal2 + etc ")"; 
            //        comando.CommandText = sql;
            //        comando.Connection = con;
            //        comando.ExecuteNonQuery();
            //        con.Close();
            //        return true;
            //    }
            //    catch
            //    {
            //        return false;
            //    }
            //}

        }
    }





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
        public const int N_PREGUNTAS = 4;
        private MySqlConnection con;
        private MySqlCommand comando;
        private String sql;

        public BindingList<Encuesta> listarEncuestas(GrupoEncuestas G)
        {
            BindingList<Encuesta> encuestas = new BindingList<Encuesta>();
            con = new MySqlConnection(DBManager.cadena);
            con.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = con;
                comando = new MySqlCommand();
                comando.CommandText = "CALL LISTAR_ENCUESTAS_Y_NCALIF";
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("_IdGrupoEncuesta", MySqlDbType.Int32).Value = G.IdGrupoEncuestas1;
                MySqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    int idEncuesta = lector.GetInt32("IdEncuesta");
                    int nCalif = lector.GetInt32("nCalif");
                    //Verifica que la encuesta sea válida (posee cierto número de calificaciones registradas)
                    //Creamos la encuesta
                    if(nCalif == N_PREGUNTAS)
                    {
                        Encuesta e = new Encuesta();
                        e.IdEncuesta1 = idEncuesta;
                        e.GrupoPerteneciente = G;
                        encuestas.Add(e);
                    }                    
                }
                con.Close();
            }
            catch (Exception){
                con.Close();
            }
            return encuestas;
        }

        public BindingList<CalificacionPXE> buscarCalificacionesDeEncuesta(Encuesta E, BindingList<Pregunta> preguntas)
        {
            BindingList<CalificacionPXE> calificaciones = new BindingList<CalificacionPXE>();
            con = new MySqlConnection(DBManager.cadena);
            con.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = con;
                comando = new MySqlCommand();
                comando.CommandText = "CALL LISTAR_CALIFICACIONES_DE_ENCUESTA";
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("_IdEncuesta", MySqlDbType.Int32).Value = E.IdEncuesta1;
                for (int i = 0; i < N_PREGUNTAS; i++)
                {
                    comando.Parameters.Add("_IdPreg" + (i+1), MySqlDbType.Int32).Value = preguntas[i].IdPregunta1;
                }
                MySqlDataReader lector = comando.ExecuteReader();
                lector.Read();
                for (int i = 1; i <= N_PREGUNTAS; i++)
                {
                    CalificacionPXE c = new CalificacionPXE(lector.GetInt32("calif" + i));
                    calificaciones.Add(c);
                }
                con.Close();
            }
            catch (Exception)
            {
                con.Close();
            }
            return calificaciones;
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





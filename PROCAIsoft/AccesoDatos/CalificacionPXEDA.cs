using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class CalificacionPXEDA
    {
        private MySqlConnection con;
        public bool registrarCalificacionPXE(CalificacionPXE c, int idEncuesta)
        {
                con = new MySqlConnection(DBManager.cadena);
                con.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = con;
            try
            {
                comando.CommandText = "REGISTRAR_CALIFICACION";
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("_calificacion", MySqlDbType.Int32).Value = c.Calificacion;
                comando.Parameters.Add("_IdPregunta", MySqlDbType.Int32).Value = c.Pregunta.IdPregunta1;
                comando.Parameters.Add("_IdEncuesta", MySqlDbType.Int32).Value = idEncuesta;
                comando.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception)
            {
                con.Close();
                return false;
            }
        }
    }
}

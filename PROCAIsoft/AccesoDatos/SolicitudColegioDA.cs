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
    public class SolicitudColegioDA
    {
        private MySqlConnection con;
        MySqlCommand comando;
        String sql;
        public BindingList<SolicitudColegio> listaSolicitudesColegios()
        {
            BindingList<SolicitudColegio> solicitudes = new BindingList<SolicitudColegio>();
            con = new MySqlConnection(DBManager.cadena);
            con.Open();
            comando = new MySqlCommand();
            sql = "SELECT * FROM SolicitudColegio;";
            comando.CommandText = sql;
            comando.Connection = con;
            MySqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                //Lectura de datos del cargo
                int idSol = lector.GetInt32("IdSolicitudColegio");
                string nom = lector.GetString("nombre");
                string telf = lector.GetString("telefono");
                string obs = lector.GetString("observacion");
                string pais = lector.GetString("pais");
                string dep = lector.GetString("departamento");
                string prov = lector.GetString("provincia");
                //Creacion del cargo
                SolicitudColegio s = new SolicitudColegio(nom, telf, obs, pais, dep, prov);
                s.IdSolicitud = idSol;
                //Agregamos el cargo a la lista
                solicitudes.Add(s);
            }
            con.Close();
            return solicitudes;
        }

        public bool registrarSolicitudColegio(SolicitudColegio s)
        {
            try
            {
                con = new MySqlConnection(DBManager.cadena);
                con.Open();
                comando = new MySqlCommand();
                sql = "INSERT INTO SolicitudColegio " +
                    "(nombre, telefono, observacion, pais, departamento, provincia) VALUES " +
                    "('" + s.Nombre + "', '" + s.Telefono + "', '" + s.Observacion + "', '" + s.Pais + "', '" + s.Departamento + "', '" + s.Provincia + "');";
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
